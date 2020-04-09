Copy the OTest.xml file to C:\Temp\ folder.(if no folder like C:\Temp, then create)
-----------------------------------------------------------------------------------------------------------

Step 1: Add a class library project
Step 2: Add OData V4 Code Generator in the Library. (Right click on the library soln=> click add new item => Click online=> Search on the right top corner as OData V4=> Select the First one and Add or Install if it is not installed.)
Step 3: Open the .tt file by double click. Add the OData Uri in the MetadataDocumentUri like below.

public const string MetadataDocumentUri = "https://icerobo-dev-34e4bae11287ed7d1devaos.cloudax.dynamics.com/Data/$metadata";

Step 4: public const string TempFilePath = ""; replace with public const string TempFilePath = "C:\\Temp\\OTest.xml";
File name you can give anything and path also according to your wish.

Step 5: Save it. It will generate the above in the particular mention path. Build the solution.

Step 6: Open the file in the NotePad++ and press ctrl+shift+f and replace all the "" to " and save it.
Step 7: Add the rest of the files as per the project and all the references also.