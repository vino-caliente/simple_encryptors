using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace lab1
{
    public partial class frmMain : Form
    {
        private const int n = 33;
        private string ReadFile;
        private string WriteFile;
        private const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public frmMain()
        {
            InitializeComponent();
            comboBoxAlg.SelectedIndex = 0;
            ReadFile = "";
            WriteFile = "";
        }

        private string Format_Str(string str)
        {
            str = str.ToUpper();
            string res = Regex.Replace(str, @"[^А-ЯЁ]", "");
            return res;
        }

        private int Format_Int_Key(string str)
        {
            string res = Regex.Replace(str, @"\D", "");
            if (res != "")
                return int.Parse(res);
            else
                return 0;
        }

        private int gcd(int a, int b)
        {
            while (a!=0 && b!=0)
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            return a + b;
        }

        private string Format_Vigenere_Key(string key, string input_text)
        {
            if (key.Length >= input_text.Length)
                return key.Substring(0, input_text.Length);
            else
                return key + input_text.Substring(0, input_text.Length - key.Length);
        }

        private string Decimation_Encrypt(string str, int key)
        {
            char[] res = new char[str.Length];

            for (int i=0; i<str.Length; i++)
            {
                int code = alphabet.IndexOf(str[i]) * key % n;
                res[i] = alphabet[code];
            }

            return new string(res);
        }

        int gcd_extended(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int x1, y1;
            int d = gcd_extended(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        private string Decimation_Decrypt(string str, int key)
        {
            // (key * reverse_key) mod n = 1
            // Расширенный алгоритм евклида: ax + by = gcd(a,b)
            // Для децимации:                (key*reverse_rey + n*y) mod n = 1
            int x, y;
            gcd_extended(key, n, out x, out y);
            // x(reverse_key) может получиться отрицательным, поэтому:
            x = (x + n) % n;
            // далее делаем то же самое, что и при шифровании, только с обратным ключом(x)
            return Decimation_Encrypt(str, x);
        }

        private string Vigenere_Encryption(string str, string key)
        {
            char[] res = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                int code = (alphabet.IndexOf(str[i]) + alphabet.IndexOf(key[i])) % n;
                res[i] = alphabet[code];
            }

            return new string(res);
        }

        private string Vigenere_Decryption(string str, string key)
        {
            char[] res = new char[str.Length];
            char[] fullkey = key.ToCharArray();
            Array.Resize(ref fullkey, str.Length);

            for (int i = 0; i < str.Length; i++)
            {
                int code = (alphabet.IndexOf(str[i]) - alphabet.IndexOf(fullkey[i]) + n) % n;
                res[i] = alphabet[code];
                if (i+key.Length < fullkey.Length)
                    fullkey[i + key.Length] = alphabet[code];  // добавление расшифрованного символа в ключ
            }

            return new string(res);
        }

        private string Get_Input()
        {
            string content = "";
            if (ReadFile == "")
                content = Format_Str(textBoxInput.Text);
            else
            {
                try
                {
                    content = Format_Str(System.IO.File.ReadAllText(ReadFile));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка {ex.Message} при чтении из файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ReadFile = "";
                textBoxInput.ReadOnly = false;
                textBoxInput.Text = content;
            }
            return content;
        }

        private void Write_Output(string str)
        {
            textBoxOutput.Text = str;
            if (WriteFile != "")
            {
                try
                {
                    System.IO.File.WriteAllText(WriteFile, str);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка {ex.Message} при сохранении в файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBoxOutput.ReadOnly = false;
                WriteFile = "";
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ReadFile = openFileDialog.FileName;
                    textBoxInput.Text = "Чтение из файла: " + ReadFile;
                    textBoxInput.ReadOnly = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовые файлы(*.txt)|*.txt";
                saveFileDialog.FilterIndex = 1;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    WriteFile = saveFileDialog.FileName;
                    textBoxOutput.Text = "Запись в файл: " + WriteFile;
                    textBoxOutput.ReadOnly = true;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxOutput.Text = "";
            ReadFile = "";
            WriteFile = "";
            textBoxInput.ReadOnly = false;
            textBoxOutput.ReadOnly = false;
            textBoxKey.Text = "";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (comboBoxAlg.SelectedIndex == 0) // Decimation
            {
                int key = Format_Int_Key(textBoxKey.Text);
                if (gcd(key, n) != 1)
                    MessageBox.Show($"Ошибка! Ключ должен быть взаимно простым с количеством букв в алфавите({n})", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string input_text = Get_Input();
                    string cipher_text = Decimation_Encrypt(input_text, key);
                    Write_Output(cipher_text);
                }
            }
            else //Vigenere
            {
                string input_text = Get_Input();
                string key = Format_Str(textBoxKey.Text);
                if (key == "")
                    MessageBox.Show($"Ошибка! Ключ должен содержать хотя бы 1 русскую букву", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    key = Format_Vigenere_Key(key, input_text);
                    string cipher_text = Vigenere_Encryption(input_text, key);
                    Write_Output(cipher_text);
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (comboBoxAlg.SelectedIndex == 0) // Decimation
            {
                int key = Format_Int_Key(textBoxKey.Text);
                if (gcd(key, n) != 1)
                    MessageBox.Show($"Ошибка! Ключ должен быть взаимно простым с количеством букв в алфавите({n})", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string input_text = Get_Input();
                    string decrypted_text = Decimation_Decrypt(input_text, key);
                    Write_Output(decrypted_text);
                }
            }
            else //Vigenere
            {
                string input_text = Get_Input();
                string key = Format_Str(textBoxKey.Text);
                if (key == "")
                    MessageBox.Show($"Ошибка! Ключ должен содержать хотя бы 1 русскую букву", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string decrypted_text = Vigenere_Decryption(input_text, key);
                    Write_Output(decrypted_text);
                }
            }
        }
    }
}
