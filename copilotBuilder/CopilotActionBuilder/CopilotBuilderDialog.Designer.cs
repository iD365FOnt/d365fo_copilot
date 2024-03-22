using System.Windows.Forms;

namespace CopilotBuilder.CopilotActionBuilder
{
    partial class CopilotBuilderDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopilotBuilderDialog));
            this.ClassNameTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.openAI = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelname = new System.Windows.Forms.TextBox();
            this.apikey = new System.Windows.Forms.TextBox();
            this.resourceURI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.Label();
            this.classTitle = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deleteParam = new System.Windows.Forms.Button();
            this.createParam = new System.Windows.Forms.Button();
            this.requiredValue = new System.Windows.Forms.CheckBox();
            this.parameterTypeValue = new System.Windows.Forms.TextBox();
            this.parameterPurposeValue = new System.Windows.Forms.TextBox();
            this.parameterNameValue = new System.Windows.Forms.TextBox();
            this.parameterType = new System.Windows.Forms.Label();
            this.parameterRequired = new System.Windows.Forms.Label();
            this.parameterPurpose = new System.Windows.Forms.Label();
            this.parameterName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.runCreation = new System.Windows.Forms.Button();
            this.copilotParams1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.copilotParamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copilotParams1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copilotParamsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassNameTextBox
            // 
            this.ClassNameTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClassNameTextBox.Location = new System.Drawing.Point(131, 20);
            this.ClassNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClassNameTextBox.Name = "ClassNameTextBox";
            this.ClassNameTextBox.Size = new System.Drawing.Size(289, 22);
            this.ClassNameTextBox.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.openAI);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.modelname);
            this.splitContainer2.Panel1.Controls.Add(this.apikey);
            this.splitContainer2.Panel1.Controls.Add(this.resourceURI);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.className);
            this.splitContainer2.Panel1.Controls.Add(this.descriptionLabel);
            this.splitContainer2.Panel1.Controls.Add(this.descriptionTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.titleTextBox);
            this.splitContainer2.Panel1.Controls.Add(this.classTitle);
            this.splitContainer2.Panel1.Controls.Add(this.ClassNameTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1088, 456);
            this.splitContainer2.SplitterDistance = 156;
            this.splitContainer2.TabIndex = 9;
            // 
            // openAI
            // 
            this.openAI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.openAI.Image = ((System.Drawing.Image)(resources.GetObject("openAI.Image")));
            this.openAI.Location = new System.Drawing.Point(948, 20);
            this.openAI.Name = "openAI";
            this.openAI.Size = new System.Drawing.Size(116, 112);
            this.openAI.TabIndex = 15;
            this.openAI.UseVisualStyleBackColor = false;
            this.openAI.Click += new System.EventHandler(this.openAI_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "API key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Resource name:";
            // 
            // modelname
            // 
            this.modelname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.modelname.Location = new System.Drawing.Point(592, 93);
            this.modelname.Margin = new System.Windows.Forms.Padding(4);
            this.modelname.Name = "modelname";
            this.modelname.Size = new System.Drawing.Size(348, 22);
            this.modelname.TabIndex = 11;
            // 
            // apikey
            // 
            this.apikey.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.apikey.Location = new System.Drawing.Point(592, 63);
            this.apikey.Margin = new System.Windows.Forms.Padding(4);
            this.apikey.Name = "apikey";
            this.apikey.Size = new System.Drawing.Size(348, 22);
            this.apikey.TabIndex = 10;
            // 
            // resourceURI
            // 
            this.resourceURI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resourceURI.Location = new System.Drawing.Point(592, 33);
            this.resourceURI.Margin = new System.Windows.Forms.Padding(4);
            this.resourceURI.Name = "resourceURI";
            this.resourceURI.Size = new System.Drawing.Size(348, 22);
            this.resourceURI.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Azure OpenAI setup:";
            // 
            // className
            // 
            this.className.AutoSize = true;
            this.className.Location = new System.Drawing.Point(13, 26);
            this.className.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(81, 16);
            this.className.TabIndex = 7;
            this.className.Text = "Class name:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 83);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(116, 16);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Action description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptionTextBox.Location = new System.Drawing.Point(131, 80);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(289, 64);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.AutoSize = true;
            this.titleTextBox.Location = new System.Drawing.Point(13, 53);
            this.titleTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(70, 16);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.Text = "Action title:";
            // 
            // classTitle
            // 
            this.classTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.classTitle.Location = new System.Drawing.Point(131, 50);
            this.classTitle.Margin = new System.Windows.Forms.Padding(4);
            this.classTitle.Name = "classTitle";
            this.classTitle.Size = new System.Drawing.Size(289, 22);
            this.classTitle.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deleteParam);
            this.splitContainer1.Panel1.Controls.Add(this.createParam);
            this.splitContainer1.Panel1.Controls.Add(this.requiredValue);
            this.splitContainer1.Panel1.Controls.Add(this.parameterTypeValue);
            this.splitContainer1.Panel1.Controls.Add(this.parameterPurposeValue);
            this.splitContainer1.Panel1.Controls.Add(this.parameterNameValue);
            this.splitContainer1.Panel1.Controls.Add(this.parameterType);
            this.splitContainer1.Panel1.Controls.Add(this.parameterRequired);
            this.splitContainer1.Panel1.Controls.Add(this.parameterPurpose);
            this.splitContainer1.Panel1.Controls.Add(this.parameterName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.runCreation);
            this.splitContainer1.Size = new System.Drawing.Size(1088, 296);
            this.splitContainer1.SplitterDistance = 583;
            this.splitContainer1.TabIndex = 0;
            // 
            // deleteParam
            // 
            this.deleteParam.Location = new System.Drawing.Point(284, 231);
            this.deleteParam.Name = "deleteParam";
            this.deleteParam.Size = new System.Drawing.Size(136, 34);
            this.deleteParam.TabIndex = 9;
            this.deleteParam.Text = "Delete param";
            this.deleteParam.UseVisualStyleBackColor = true;
            this.deleteParam.Click += new System.EventHandler(this.deleteParam_Click);
            // 
            // createParam
            // 
            this.createParam.Location = new System.Drawing.Point(426, 230);
            this.createParam.Name = "createParam";
            this.createParam.Size = new System.Drawing.Size(136, 34);
            this.createParam.TabIndex = 8;
            this.createParam.Text = "Create param";
            this.createParam.UseVisualStyleBackColor = true;
            this.createParam.Click += new System.EventHandler(this.createParam_Click);
            // 
            // requiredValue
            // 
            this.requiredValue.AutoSize = true;
            this.requiredValue.Location = new System.Drawing.Point(179, 240);
            this.requiredValue.Name = "requiredValue";
            this.requiredValue.Size = new System.Drawing.Size(18, 17);
            this.requiredValue.TabIndex = 7;
            this.requiredValue.UseVisualStyleBackColor = true;
            // 
            // parameterTypeValue
            // 
            this.parameterTypeValue.Location = new System.Drawing.Point(179, 194);
            this.parameterTypeValue.Name = "parameterTypeValue";
            this.parameterTypeValue.Size = new System.Drawing.Size(383, 22);
            this.parameterTypeValue.TabIndex = 6;
            // 
            // parameterPurposeValue
            // 
            this.parameterPurposeValue.Location = new System.Drawing.Point(179, 69);
            this.parameterPurposeValue.Multiline = true;
            this.parameterPurposeValue.Name = "parameterPurposeValue";
            this.parameterPurposeValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.parameterPurposeValue.Size = new System.Drawing.Size(383, 110);
            this.parameterPurposeValue.TabIndex = 5;
            // 
            // parameterNameValue
            // 
            this.parameterNameValue.Location = new System.Drawing.Point(179, 28);
            this.parameterNameValue.Name = "parameterNameValue";
            this.parameterNameValue.Size = new System.Drawing.Size(383, 22);
            this.parameterNameValue.TabIndex = 4;
            // 
            // parameterType
            // 
            this.parameterType.AutoSize = true;
            this.parameterType.Location = new System.Drawing.Point(20, 196);
            this.parameterType.Name = "parameterType";
            this.parameterType.Size = new System.Drawing.Size(105, 16);
            this.parameterType.TabIndex = 3;
            this.parameterType.Text = "Parameter Type";
            // 
            // parameterRequired
            // 
            this.parameterRequired.AutoSize = true;
            this.parameterRequired.Location = new System.Drawing.Point(20, 241);
            this.parameterRequired.Name = "parameterRequired";
            this.parameterRequired.Size = new System.Drawing.Size(63, 16);
            this.parameterRequired.TabIndex = 2;
            this.parameterRequired.Text = "Required";
            // 
            // parameterPurpose
            // 
            this.parameterPurpose.AutoSize = true;
            this.parameterPurpose.Location = new System.Drawing.Point(20, 69);
            this.parameterPurpose.Name = "parameterPurpose";
            this.parameterPurpose.Size = new System.Drawing.Size(123, 16);
            this.parameterPurpose.TabIndex = 1;
            this.parameterPurpose.Text = "Parameter purpose";
            // 
            // parameterName
            // 
            this.parameterName.AutoSize = true;
            this.parameterName.Location = new System.Drawing.Point(20, 31);
            this.parameterName.Name = "parameterName";
            this.parameterName.Size = new System.Drawing.Size(107, 16);
            this.parameterName.TabIndex = 0;
            this.parameterName.Text = "Parameter name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 196);
            this.dataGridView1.TabIndex = 2;
            // 
            // runCreation
            // 
            this.runCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runCreation.Location = new System.Drawing.Point(75, 205);
            this.runCreation.Name = "runCreation";
            this.runCreation.Size = new System.Drawing.Size(343, 60);
            this.runCreation.TabIndex = 1;
            this.runCreation.Text = "Create class";
            this.runCreation.UseVisualStyleBackColor = true;
            this.runCreation.Click += new System.EventHandler(this.runCreation_Click);

            // 
            // CopilotBuilderDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1088, 456);
            this.Controls.Add(this.splitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CopilotBuilderDialog";
            this.Text = "Create copilot action";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copilotParams1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copilotParamsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ClassNameTextBox;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label titleTextBox;
        private System.Windows.Forms.TextBox classTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label parameterType;
        private System.Windows.Forms.Label parameterRequired;
        private System.Windows.Forms.Label parameterPurpose;
        private System.Windows.Forms.Label parameterName;
        private System.Windows.Forms.CheckBox requiredValue;
        private System.Windows.Forms.TextBox parameterTypeValue;
        private System.Windows.Forms.TextBox parameterPurposeValue;
        private System.Windows.Forms.TextBox parameterNameValue;
        private System.Windows.Forms.Label className;
        //private CopilotActionBuilder.CopilotParams copilotParams1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button createParam;
        private System.Windows.Forms.Button deleteParam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox modelname;
        private System.Windows.Forms.TextBox apikey;
        private System.Windows.Forms.TextBox resourceURI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openAI;
        private System.Windows.Forms.Button runCreation;
        private DataGridView dataGridView1;
        private BindingSource copilotParams1BindingSource;
        private BindingSource copilotParamsBindingSource;
    }
}