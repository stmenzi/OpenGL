using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Graphics
{
    class FileManager
    {
        /****************************************************************/
        /*                       class characteristics                  */
        /****************************************************************/
        string Filename { get; set; }
        FileStream fRead;
        FileStream fWrite;
        public string textRead { get; set; }
        public byte[] bufRead;
        public byte[] byfWrite;

        /****************************************************************/
        /*                           constructor                        */
        /****************************************************************/
        public FileManager(string filename)
        {
            Filename = filename;
        }

        /****************************************************************/
        public void writeFile(string text)
        {
            //Σβήσιμο όλων των περιεχομένων του αρχείου πριν τη νέα εγγραφή
            System.IO.File.WriteAllText(Filename, string.Empty);


            fWrite = new FileStream(Filename, FileMode.OpenOrCreate, FileAccess.Write);

            try
            {
                if (fWrite.CanWrite)
                {
                    //Γράψιμο των δεδομένων στο αρχείο
                    byfWrite = Encoding.UTF8.GetBytes(text);
                    fWrite.Write(byfWrite, 0, byfWrite.Length);
                }
            }
            finally
            {
                fWrite.Flush();
                fWrite.Close();
            }
        }
        /****************************************************************/
        public string readFile()
        {
            fRead = new FileStream(Filename, FileMode.Open, FileAccess.Read);
            int bytesRead;

            try
            {
                if (fRead.CanRead){
                    bufRead = new byte[fRead.Length];
                    bytesRead = fRead.Read(bufRead, 0, bufRead.Length);
                    textRead = Encoding.UTF8.GetString(bufRead);
                }
                else
                {
                    MessageBox.Show("File could not be read");
                }
            }
            finally {
                fRead.Close();
            }            
            return textRead;
        }
        /****************************************************************/
    }
}
