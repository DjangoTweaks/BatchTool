# BatchToDbTool

## How to Use

1. **Run the Application:**
   - Open a terminal and navigate to the folder containing `BatchToDbTool.exe`.
   - Run the command: 
     ```
     BatchToDbTool.exe
     ```

2. **Provide Inputs:**
   - **Folder Path:** Enter the full directory path where your batch files are located.  
     Example:  
     ```
     C:\Users\YourUser\Documents\BatchFiles
     ```
   - **CSV File Path:** Enter the full file path where you want the CSV output to be saved.  
     Example:  
     ```
     C:\Users\YourUser\Documents\Output\batchFiles.csv
     ```

3. **CSV Generation:**
   - The tool reads all batch files from the specified folder.
   - It generates a CSV with two columns: `BatchTitle` (file name) and `BatchContent` (file contents).
   - The CSV file automatically opens after the process is complete.

4. **Completion:**
   - A message "Finished" will appear once the process is done.

5. **Import CSV into MongoDB using Compass:**
   - Open **MongoDB Compass** and connect to your database.
   - Select the database where you want to import the CSV file.
   - Click on the **collection** you want to import the data into, or create a new collection.
   - Click on the **"Add Data"** button and select **"Import File."**
   - Choose the CSV file you generated (`batchFiles.csv`) and select **"CSV"** as the file type.
   - Ensure the option **"First line contains headers"** is checked.
   - Click **"Import"** to add the data to your collection.
