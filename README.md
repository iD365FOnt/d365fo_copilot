# Copilot Actions for Dynamics 365 Finance and Operations Add-in (in construction)

## Table of Contents
1. [Description](#description)
2. [Installation](#installation)
3. [Usage](#usage)

## Description

The "Copilot Actions for Dynamics 365 Finance and Operations Add-in" is a Visual Studio extension designed to streamline the creation of classes responsible for triggering actions within the Dynamics 365 Finance and Operations (D365FO) environment. By utilizing an intuitive form-based interface, this add-in generates the necessary code, simplifying the development process for D365FO integrations and extensions.

![Captura de pantalla 2024-03-20 174353](https://github.com/iD365FOnt/d365fo_copilot/assets/103633861/71a12b37-153d-4cc3-b5d2-ff463646d911)

## Installation

To install the extension, follow these steps:

1. Locate the `AddInExtensions` folder within your Visual Studio installation directory using Windows Explorer:
   - Open Windows Explorer and navigate to your Visual Studio installation directory.
   - The typical path is: `C:\Program Files (x86)\Microsoft Visual Studio\<Visual Studio Version>\Common7\IDE\Extensions\Microsoft\Dynamics365\FnO\AddInExtensions`.
   - You can also search for the folder using the Windows search feature by typing "AddInExtensions".

2. Once you have located the `AddInExtensions` folder, copy the files `id365font.dll` and `id365font.pdb` into this folder.

3. After copying the files, restart Visual Studio to apply the changes.

Once completed, the extension will be installed and ready for use within Visual Studio.



## Usage

Using the extension involves the following steps:

1. Within the Visual Studio development environment, access the Dynamics 365 extensions menu by selecting **Extensions > Dynamics 365 > id365font - Create copilot action**.

2. In the provided form, enter the necessary details to create a Copilot action:
    - Specify the name of the class to create.
    - Provide a descriptive title explaining the functionality.
    - Include a detailed description of the intended functionality.

3. Optionally, define any parameters required for the action and specify their mandatory status.

4. After providing all required details, you have two options:
    - Option A: Click "Create class" to manually generate the class structure in the current project.
    - Option B: Utilize the built-in OpenAI functionality to automatically generate descriptions for both the class and parameters. To do so, input the OpenAI resource, API key, and select the desired model, then click the OpenAI logo to activate automatic description generation.

5. If you choose Option A or B and confirm the action by clicking "Create class", the extension will automatically generate a class in the active project, structured for invocation from the Copilot chat.

6. Once the class is created, simply populate the `executeAction` method with the corresponding code to execute the desired functionality.

This streamlined process offers an efficient way to integrate new functionalities into the Dynamics 365 Finance and Operations environment, leveraging the code generation and description capabilities provided by both the extension and OpenAI.

