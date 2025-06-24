using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace Graphics
{
    class OutputRedirect
    {

        // Define static variables shared by class methods. 
        private static StringBuilder regMsgOutput = null;
        private static int numOutputLines = 0;  //sum of lines we get from process output

        public static void InputText(string projPath, string exePath)
        {
            // Get access to mainForm public variables
            var form = Form.ActiveForm as mainForm;

            //Get paths for current example
            //string projPath = "C:\\examples\\" + form.exampleName + "\\" + form.exampleName +"\\" + form.exampleName + ".vcxproj";
            //string exePath = "C:\\examples\\" + form.exampleName + "\\Debug\\" + form.exampleName + ".exe";

            //Set encoding to windows language
            System.Text.Encoding systemencoding = System.Text.Encoding.GetEncoding(System.Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage);

            // Initialize the process and its StartInfo properties. 
            
            Process msbuildProcess;
            msbuildProcess = new Process();
            msbuildProcess.StartInfo.FileName = "C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\MSBuild.exe";
            msbuildProcess.StartInfo.Arguments = projPath;

            // Set UseShellExecute to false for redirection.
            msbuildProcess.StartInfo.UseShellExecute = false;

            // Redirect the standard output of the sort command.   
            // This stream is read asynchronously using an event handler.
            msbuildProcess.StartInfo.RedirectStandardOutput = true;
            msbuildProcess.StartInfo.StandardOutputEncoding = systemencoding;
            regMsgOutput = new StringBuilder("");
            
            // Set our event handler to asynchronously read the sort output.
            msbuildProcess.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);

            // Redirect standard input as well.  This stream 
            // is used synchronously.
            msbuildProcess.StartInfo.RedirectStandardInput = true;

            // Start the process.
            msbuildProcess.Start();


            // Start the asynchronous read of the output stream.
            msbuildProcess.BeginOutputReadLine();

            // Wait for the process to write output.
            msbuildProcess.WaitForExit();

            if (numOutputLines > 0)
            {
                // Write the  output to the regular messages text box.
                form.regularMsg.Text += regMsgOutput.ToString();
            }
    
            msbuildProcess.Close();

            if (!regMsgOutput.ToString().Contains("error")) {
                System.Diagnostics.Process.Start(exePath);
            }
        }
        private static string PrintCPBytes(string str, int codePage)
        {
            Encoding targetEncoding;
            byte[] encodedChars;

            // Gets the encoding for the specified code page.
            targetEncoding = Encoding.GetEncoding(codePage);

            // Gets the byte representation of the specified string.
            encodedChars = targetEncoding.GetBytes(str);

            // Prints the bytes.
            string message = "";  
            for (int i = 0; i < encodedChars.Length; i++)
                message += encodedChars[i].ToString();

            return message;
        }

        private static void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            // Collect the msbuild command output. 
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                numOutputLines++;
                
                // Add the text to the collected output.
                regMsgOutput.Append(Environment.NewLine + outLine.Data);  
            }
        }
    }
}
