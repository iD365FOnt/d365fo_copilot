using System;
using System.Collections.Generic;
using System.Linq;
using CopilotBuilder.Kernel;
using Microsoft.Dynamics.AX.Metadata.MetaModel;
using Microsoft.Dynamics.Framework.Tools.MetaModel.Core;
using static CopilotBuilder.CopilotActionBuilder.CopilotParams;


namespace CopilotBuilder.CopilotActionBuilder
{
    public class CopilotActionBuilder
    {
        public string Type { get; set; } = "";
        public string Name { get; set; } = "";
        public string Label { get; set; } = "";
        public string LabelHelp { get; set; } = "";
        public string GroupName { get; set; } = "";
        public string GroupLabel { get; set; } = "";
        public Boolean IsMandatory { get; set; }

        //calculated 
        public int PositionInGroup;

        public override string ToString()
        {
            return $"Type:{Type}, varName:{Name}, Mandatory:{IsMandatory}, Label:{Label}, Help:{LabelHelp}";
        }
    }


    public class CopilotActionBuilderParms : SnippedCreateAction
    {
        public string ClassName { get; set; } = "";

        public string ClassTitle { get; set; } = "";

        public string ClassDescription { get; set; } = "";

        public CopilotParamsDataTable FieldsList = new CopilotParamsDataTable();

        protected AxClass NewAxClass;

        void InitCodeGenerate()
        {
            CodeGenerate = new CodeGenerateHelper { IndentGlobalValue = 0 };
        }

        private void CopilotClassDeclaration()
        {
            CodeGenerate.SetMethodName("ClassDeclaration", ClassMethodType.ClassDeclaration);
            CodeGenerate.AppendLine("[");
            CodeGenerate.IndentIncrease();
            CodeGenerate.Append("DataContract");            
            CodeGenerate.AppendLine("").IndentDecrease();
            CodeGenerate.AppendLine("]");

            CodeGenerate.AppendLine("[");
            CodeGenerate.IndentIncrease();
            CodeGenerate.Append("SysCopilotChatGlobalAction");
            CodeGenerate.AppendLine("").IndentDecrease();
            CodeGenerate.AppendLine("]");

            CodeGenerate.AppendLine("[");
            CodeGenerate.IndentIncrease();
            CodeGenerate.Append("SysCopilotChatActionDefinition(identifiedStr(ExampleCopilot), '"+ ClassTitle +"', '" + ClassDescription + "', menuItemActionStr(ExampleCopilot), MenuItemType::Action)");
            CodeGenerate.AppendLine("").IndentDecrease();
            CodeGenerate.AppendLine("]");

            CodeGenerate.Append($"public class {ClassName}");

            CodeGenerate.AppendLine(" extends SysCopilotChatAction");

            CodeGenerate.BeginBlock();
            foreach (CopilotParamsRow df in FieldsList)
            {
                CodeGenerate.Append(df.ParameterType, "Type").AppendLine($" {df.ParameterName};");
            }

            CodeGenerate.AppendLine("");
            CodeGenerate.EndBlock();
            CodeGenerate.IndentIncrease();
        }


        void CopilotParmMethod(CopilotParamsRow parmVar)
        {
            string mName = $"parm{AxHelper.UppercaseWords(parmVar.ParameterName)}";
            CodeGenerate.SetMethodName(mName);

            CodeGenerate.AppendLine("[");
            CodeGenerate.IndentIncrease();
            CodeGenerate.ProcessLastSym(",");
            CodeGenerate.Append($"DataMember(identifierStr({AxHelper.UppercaseWords(parmVar.ParameterName)}))");
            if (!String.IsNullOrEmpty(parmVar.Purpose))
            {
                CodeGenerate.ProcessLastSym(",");
                CodeGenerate.Append($"SysCopilotChatActionInputParameter(literalstr(\"{parmVar.Purpose}\"), {parmVar.Required})");
            }            

            CodeGenerate.AppendLine("").IndentDecrease();
            CodeGenerate.AppendLine("]");

            CodeGenerate.AppendLine($"public {parmVar.ParameterType} {mName}({parmVar.ParameterType} _{parmVar.ParameterName} = {parmVar.ParameterName})");
            CodeGenerate.BeginBlock();
            CodeGenerate.AppendLine($"{parmVar.ParameterName} = _{parmVar.ParameterName};");
            CodeGenerate.AppendLine($"return {parmVar.ParameterName};");
            CodeGenerate.EndBlock();
        }


        private void CopilotExecuteAction()
        {
            CodeGenerate.SetMethodName("executeAction");
            CodeGenerate.AppendLine("public void executeAction(SysCopilotChatActionDefinitionAttribute _actionDefinition, Object _context)");
            CodeGenerate.BeginBlock();                
            CodeGenerate.EndBlock();
        }

        void AddMethodCode()
        {
            AddClassMethodCode(NewAxClass);
        }

        void CreateCopilotMethodsContract()
        {
            InitCodeGenerate();
            CopilotClassDeclaration(); AddMethodCode();
            foreach (CopilotParamsRow df in FieldsList)
            {
                CopilotParmMethod(df); AddMethodCode();
            }
            CopilotExecuteAction(); AddMethodCode();
        }


        void CreateClass()
        {
            AxHelper axHelper = new AxHelper();

            NewAxClass = axHelper.MetadataProvider.Classes.Read(ClassName);

            if (NewAxClass != null)
            {
                throw new Exception($"Class {ClassName} already exists");
            }

            NewAxClass = new AxClass { Name = ClassName };
            CreateCopilotMethodsContract();

            axHelper.MetaModelService.CreateClass(NewAxClass, axHelper.ModelSaveInfo);
            axHelper.AppendToActiveProject(NewAxClass);

            AddLog($"Class: {NewAxClass.Name}; ");
        }

        //crea un método parm para almacenar ClassNameText.Text

        public void parmClassName(string _className)
        {
            ClassName = _className;
        }

        public void parmClassTitle(string _classTitle)
        {
            ClassTitle = _classTitle;
        }

        //parm para descriptionTextBox
        public void parmDescription(string _description)
        {
            ClassDescription = _description;
        }

        //parm para CopilotParamsDataTable
        public void parmFieldsList(CopilotParamsDataTable _fieldsList)
        {
            FieldsList = _fieldsList;
        }



        public override void RunCreate()
        {
            CreateClass();
        }
    }
}