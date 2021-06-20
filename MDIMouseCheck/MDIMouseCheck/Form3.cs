using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace MDIMouseCheck
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("../../../fs.txt"))
            {
                sw.Write(textBox1.Text);
                MessageBox.Show("텍스트가 파일에 저장되었습니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                using (StreamReader sr = new StreamReader("../../../fs.txt"))
                {
                    textBox1.Text = sr.ReadToEnd();
                }

            }
            catch (Exception exception)
            {
                string errorMsg = "예외 발생";
                errorMsg = errorMsg + "\n" + "exception type: " + exception.GetType() + "\n" + exception.Message + "\n스택트레이스: " + exception.StackTrace;
                MessageBox.Show("이 형식은 읽을 수 없습니다");
                MessageBox.Show(errorMsg);
                using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, errorMsg);
                    MessageBox.Show("exception이 저장되었습니다.");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All File|*.*|Text|*.txt|Binary|*.bin";
            saveFileDialog.Title = "Save an Text File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                if (saveFileDialog.FileName.Contains(".txt"))
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.Write(textBox1.Text);
                    }
                }
                else if (saveFileDialog.FileName.Contains(".bin"))
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, textBox1.Text);
                    }
                }
                else
                {
                    MessageBox.Show("형식을 정해주세요");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All File|*.*|Text|*.txt|Binary|*.bin";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ShowDialog();
            try
            {
                if (openFileDialog.FileName != "") 
                {
                    if (openFileDialog.FileName.Contains(".txt"))
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                        {
                            textBox1.Text = sr.ReadToEnd();
                        }
                    }
                    else if (openFileDialog.FileName.Contains(".bin"))
                    {
                        using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                        {
                            textBox1.Text = "";
                            string result;

                            BinaryFormatter bf = new BinaryFormatter();
                            result = (string)bf.Deserialize(fs);
                            textBox1.Text = result;
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception exception)
            {
                string errorMsg = "예외 발생";
                errorMsg = errorMsg + "\n" + "exception type: " + exception.GetType() + "\n" + exception.Message + "\n스택트레이스: " + exception.StackTrace;
                MessageBox.Show("이 형식은 읽을 수 없습니다");
                MessageBox.Show(errorMsg);
                using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, errorMsg);
                    MessageBox.Show("exception이 저장되었습니다.");
                }
            }
        }

        private void buttonSerial_Click(object sender, EventArgs e)
        {
           //직렬화
            using (FileStream fs = new FileStream("../../../Binary.bin", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, textBox1.Text);
                MessageBox.Show("텍스트가 바이너리로 파일에 저장되었습니다.");
            }
        }

        private void buttonDeserial_Click(object sender, EventArgs e)
        {
            // 역직렬화
            try
            {
                using (FileStream fs = new FileStream("../../../Binary.bin", FileMode.Open)) 
                {
                    if (fs.Name.Contains(".bin"))
                    {
                        textBox1.Text = "";
                        string result;

                        BinaryFormatter bf = new BinaryFormatter();
                        result = (string)bf.Deserialize(fs);
                        textBox1.Text = result;
                        MessageBox.Show("바이너리를 모두 읽어왔습니다.");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }      
            }
            catch (Exception exception)
            {
                string errorMsg = "예외 발생";
                errorMsg = errorMsg + "\n" + "exception type: " + exception.GetType() + "\n" + exception.Message + "\n스택트레이스: " + exception.StackTrace;
                MessageBox.Show("이 형식은 읽을 수 없습니다");
                MessageBox.Show(errorMsg);
                using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, errorMsg);
                    MessageBox.Show("exception이 저장되었습니다.");
                }
            }
        }

        private void buttonChooseSave_Click(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked == true && checkBoxSaveSerial.Checked == true)
            {
                using (StreamWriter sw = new StreamWriter("../../normal.txt"))
                {
                    sw.Write(textBox1.Text);
                    MessageBox.Show("텍스트가 파일에 저장되었습니다.");
                }

                using (FileStream fs = new FileStream("../../se.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, textBox1.Text);
                    MessageBox.Show("텍스트가 바이너리로 파일에 저장되었습니다.");
                }
            }
            else if(checkBoxSave.Checked == true)
            {
                using (StreamWriter sw = new StreamWriter("../../normal.txt"))
                {
                    sw.Write(textBox1.Text);
                    MessageBox.Show("텍스트가 파일에 저장되었습니다.");
                }
            }
            else if(checkBoxSaveSerial.Checked == true)
            {
                using (FileStream fs = new FileStream("../../se.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, textBox1.Text);
                    MessageBox.Show("텍스트가 바이너리로 파일에 저장되었습니다.");
                }
            }
            else
            {
                MessageBox.Show("아무것도 선택 안했습니다");
            }

            if (checkBoxSave.CheckState == CheckState.Checked || checkBoxSaveSerial.CheckState == CheckState.Checked)
            {
                checkBoxSave.CheckState = CheckState.Unchecked;
                checkBoxSaveSerial.CheckState = CheckState.Unchecked;
            }

        }
        private void buttonChooseRead_Click(object sender, EventArgs e)
        {
            if (radioButtonRead.Checked == true)
                try
                {
                    textBox1.Text = "";
                    using (StreamReader sr = new StreamReader("../../normal.txt"))
                    {
                        textBox1.Text = sr.ReadToEnd();
                    }
                    radioButtonRead.Checked = false;
                }
                catch (Exception exception)
                {
                    string errorMsg = "예외 발생";
                    errorMsg = errorMsg + "\n" + "exception type: " + exception.GetType() + "\n" + exception.Message + "\n스택트레이스: " + exception.StackTrace;
                    MessageBox.Show("이 형식은 읽을 수 없습니다");
                    MessageBox.Show(errorMsg);
                    using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, errorMsg);
                        MessageBox.Show("exception이 저장되었습니다.");
                    }
                }

            else if (radioButtonDeserial.Checked == true)
            {
                try
                {
                    using (FileStream fs = new FileStream("../../se.bin", FileMode.Open))
                    {
                        if (fs.Name.Contains(".bin"))
                        {
                            textBox1.Text = "";
                            string result;

                            BinaryFormatter bf = new BinaryFormatter();
                            result = (string)bf.Deserialize(fs);
                            textBox1.Text = result;
                            MessageBox.Show("바이너리를 모두 읽어왔습니다.");
                            radioButtonDeserial.Checked = false;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                catch (Exception exception)
                {
                    string errorMsg = "예외 발생";
                    errorMsg = errorMsg + "\n" + "exception type: " + exception.GetType() + "\n" + exception.Message + "\n스택트레이스: " + exception.StackTrace;
                    MessageBox.Show("이 형식은 읽을 수 없습니다");
                    MessageBox.Show(errorMsg);
                    using (FileStream fs = new FileStream("../../../error.log", FileMode.Create))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, errorMsg);
                        MessageBox.Show("exception이 저장되었습니다.");
                    }
                }
            }
            else
            {
                MessageBox.Show("아무것도 선택 되지 않았습니다");
            }
        }

        private void radioButtonRead_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
