using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure;
using Azure.AI.OpenAI;
using Microsoft.Dynamics.AX.Metadata.Core.MetaModel;
using CopilotBuilder.CopilotActionBuilder;
using CopilotBuilder.Kernel;
using static CopilotBuilder.CopilotActionBuilder.CopilotParams;
using static CopilotBuilder.CopilotActionBuilder.RequestClass;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace CopilotBuilder.CopilotActionBuilder
{
    public partial class CopilotBuilderDialog : Form
    {
        private CopilotParamsDataTable dt;
        public CopilotBuilderDialog()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Parameter Name";
            dataGridView1.Columns[1].Name = "Parameter Type";
            dataGridView1.Columns[2].Name = "Purpose";
            dataGridView1.Columns[3].Name = "Required";

            dt = new CopilotParamsDataTable();
        }

        private void createParam_Click(object sender, EventArgs e)
        {
            CopilotParamsRow newRow = (CopilotParamsRow)dt.NewRow();

            newRow["ParameterName"] = parameterNameValue.Text;            
            newRow["Purpose"] = parameterPurposeValue.Text;
            newRow["ParameterType"] = parameterTypeValue.Text;
            newRow["Required"] = requiredValue.Checked;

            dt.Rows.Add(newRow);

            dataGridView1.Rows.Add(newRow.ItemArray);
            dataGridView1.Update();
            dataGridView1.Refresh();

            parameterNameValue.Text = "";
            parameterTypeValue.Text = "";
            parameterPurposeValue.Text = "";
            requiredValue.Checked = false;
        }

        private void deleteParam_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow == null)
            {
                return;
            }
            dt.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void openAI_Click(object sender, EventArgs e)
        {
            if(resourceURI.Text == "" || apikey.Text == "" || modelname.Text == "")
            {
                MessageBox.Show("Please fill in the Azure OpenAI resource URI, API key, and model name.");
                return;
            }

            string azureOpenAIResourceUri = resourceURI.Text;
            string azureOpenAIResourceApiKey = apikey.Text;

            // Crea una instancia del cliente de Azure OpenAI
            OpenAIClient client = new OpenAIClient(new Uri(azureOpenAIResourceUri), new AzureKeyCredential(azureOpenAIResourceApiKey));

            RequestClass.Root root = new RequestClass.Root();
            root.parameters = new List<RequestClass>();

            foreach (DataRow row in dt.Rows)
            {
                
                root.parameters.Add(new RequestClass() { parameterName = row["ParameterName"].ToString() });
            }
            
            root.classDescription = classTitle.Text;

            string jsonString = JsonConvert.SerializeObject(root);

            var chatCompletionsOptions = new ChatCompletionsOptions()
            {
                DeploymentName = modelname.Text, // Use DeploymentName for "model" with non-Azure clients
                Messages =
                            {
                                // The system message represents instructions or other guidance about how the assistant should behave
                                new ChatRequestSystemMessage("You are an assistant responsible for helping in the creation of a class to be used for calling actions from the Finance and Operations Copilot chat. I'm going to pass you a JSON with the purpose of the action and the parameters that I need it to have. With this, I need the description of each parameter so that Copilot knows it. I also need the description of the class so that Copilot identifies what its function is. You must respond only the JSON format."),
                                // User messages represent current or historical input from the end user
                                new ChatRequestUserMessage("Copilot Action for: creation of sales orders. Parameters: customer, item, quantity"),
                                // Assistant messages represent historical responses from the assistant
                                new ChatRequestAssistantMessage("{\"classDescription\":\"Launches the action for creating sales orders\",\"parameters\":[{ \"parameterName\":\"customer\",\"parameterPurpose\":\"Customer associated with the sales order\"},{ \"parameterName\":\"item\",\"parameterPurpose\":\"Item of the order to be sold\"},{ \"parameterName\":\"quantity\",\"parameterPurpose\":\"Quantity of product to be sold\"}]}"),
                                //new ChatRequestAssistantMessage("{\r\n  \"generalPurpose\": \"\",\r\n  \"parameters\": [\r\n    {\r\n      \"parameterName\": \"\",\r\n      \"parameterPurpose\": \"\"\r\n    }\r\n  ]\r\n}\r\n"),
                                new ChatRequestUserMessage(jsonString),
                            },
                Temperature = 0

            };

            try
            {                 // Call the chat completion endpoint
                Response<ChatCompletions> response = client.GetChatCompletions(chatCompletionsOptions);
                ChatResponseMessage responseMessage = response.Value.Choices[0].Message;

                //find a JSON inside the response
                string JSONresponse = responseMessage.Content.Substring(responseMessage.Content.IndexOf("{"), responseMessage.Content.LastIndexOf("}") - responseMessage.Content.IndexOf("{") + 1);

                ResponseBlock responseClass = JsonConvert.DeserializeObject<ResponseBlock>(JSONresponse);

                foreach (var responseParam in responseClass.parameters)
                {
                    //find the row with parameterName and update the purpose
                    DataRow[] rows = dt.Select($"ParameterName = '{responseParam.parameterName}'");
                    rows[0]["Purpose"] = responseParam.parameterPurpose;
                    dataGridView1.Rows[rows[0].Table.Rows.IndexOf(rows[0])].Cells[2].Value = responseParam.parameterPurpose;
                }

                descriptionTextBox.Text = responseClass.classDescription;
            }
            catch (RequestFailedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void runCreation_Click(object sender, EventArgs e)
        {
            //call copilotactionbuilderparms runcreate method
            CopilotActionBuilderParms parms = new CopilotActionBuilderParms();
            parms.ClassName = ClassNameTextBox.Text;
            parms.ClassTitle = classTitle.Text;
            parms.ClassDescription = descriptionTextBox.Text;
            parms.FieldsList = dt;
            parms.RunCreate();
        }
    }
}
