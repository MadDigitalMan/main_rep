using System;
using System.Collections.Generic;
using System.IO;

namespace NumberSign
{
    class Program
    {
        public static List<string> readFile(string path) //считыввет информацию с файла text1.txt
        {
            List<string> text = new List<string>();
            StreamReader reader = new StreamReader(path);
            string str;
            while ((str = reader.ReadLine()) != null)
            {
                if ((str = str.Trim()) != null)
                    text.Add(str);
            }
            reader.Close();
            Console.WriteLine("This file was succesfully read");
            return text;
        }

        public static bool createFile(string name) //в этой фунции создаем новый файл text2.txt
        {
            try
            {
                string patch = Directory.GetCurrentDirectory() + '\\' + name;
                FileStream fstream = new FileStream(patch, FileMode.OpenOrCreate);
                System.IO.File.SetAttributes(patch, FileAttributes.Normal);
                fstream.Close();
                Console.WriteLine("This file was succesfully created\n\n");
                return true;
            }
            catch (Exception e) { return false; }
        }

        public static bool writeFile(List<string> setwords, string path, bool pr)
        {
            if (setwords.Count == 0) 
                return true;
            File.WriteAllText(path, string.Empty); //записи указанной строки в файл - в нашем случае - text.txt , а затем закрывает файл.
            StreamWriter write = new StreamWriter(path, pr);
            write.WriteLine("Programmer: Makarevich Egor \n");
            foreach (string value in setwords)
            {
                write.WriteLine(value);
            }
            int processed = Convert.ToInt32(setwords.Count); //обьявленная переменная вычисляет количество элементов массива 
            write.WriteLine("\nNunmers of plates processed:" + processed + "\n");
            write.Close();
            return true;
        }

        public static bool CorrectSymbol(string symbol)
        {
            if (symbol.Length == 8)
            {
                if ((symbol[0] >= 'A') && (symbol[0] <= 'Z') &&
                (symbol[1] >= 'A') && (symbol[1] <= 'Z') &&
                (symbol[2] >= 'A') && (symbol[2] <= 'Z') &&
                (symbol[3] == ' ') &&
                (symbol[4] >= '0') && (symbol[4] <= '9') &&
                (symbol[5] >= '0') && (symbol[5] <= '9') &&
                (symbol[6] >= '0') && (symbol[6] <= '9') &&
                (symbol[7] >= '0') && (symbol[7] <= '9'))
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        public static List<string> mass(List<string> setwords) //массив необработанных номеров
        {
            List<string> text = new List<string>();

            foreach (string element in setwords)
            {
                text.Add(element + " ---> " + Change_symbol(element));  // сопоставление необработанных номеров обработанным и добавление в ...
                Console.WriteLine(element + " ---> " + Change_symbol(element));

            }
            return text;
        }
        public static string Change_symbol(string symbol)
        {
            symbol = symbol.Trim(); // удаляет пробелы 
            string s;    
            if (CorrectSymbol(symbol))
            {
                string numb = symbol.Substring(4);
                string letters = symbol.Substring(0, 3);
                if (symbol == "ZZZ 9999")
                {
                    s = "Конечный элемент";
                }
                else
                {
                    if (Convert.ToInt32(numb) < 9999)  //если число меньше 9999
                    {
                        numb = Convert.ToString(Convert.ToInt32(numb) + 1);       //следующие число с шагом 1
                        while (numb.Length < 4)  //если число меньше 1000 (длина 3), то в начале будет 0                                
                        {
                            numb = numb.Insert(0, "0");                           //добавление нулей убранных приконвертации строки, содержащей цифры в целочисленный тип
                        }
                        s = (symbol.Substring(0, 4)) + numb.ToString();           // s - номер состоящий из буквенной и числовой части

                    }

                    else
                    {
                        if ((letters[1] == 'Z') && (letters[2] == 'Z'))                         //AZZ 9999 //проверка, в случае если вторая и третья буква Z
                        {
                            letters = Convert.ToChar((Convert.ToInt32(letters[0]) + 1)) + "AA";
                            s = letters + " 0000";                                                         //номер буквенная часть вида (х + 1)АА 0000                         
                        }
                        else if (letters[2] == 'Z')                                             //ABZ 9999 //проверка, в случае если третья буква Z
                        {
                            letters = letters[0] + Convert.ToChar(Convert.ToInt32(letters[1]) + 1) + "A"; // тогда первая буква неизменна, вторая меняется на следующую, третья - А
                            s = letters + " 0000";

                        }
                        else                                                                    // ABC 9999  //проверка если произвольное буквенная часть и число меньшее 9999
                        {
                            letters = Convert.ToString(letters[0]) + Convert.ToString(letters[1]) + Convert.ToChar((Convert.ToInt32(letters[2]) + 1)); //первые 2 буквы неизменны, третее число с шагом 1
                            s = letters + " 0000";

                        }
                    }

                }
            }
            else
            {
                s = "Некорректный ввод";
            }
            return s;

        }
        static void Main(string[] args)
        {
            List<string> first = new List<string>();
            first = readFile("text1.txt");                                                     //вызываем функцию для чтения файла text.txt
            first.Remove("Plate Numbers");                                                    //удаляеем из обрабатываемых номеров строку Plate Numbers
            createFile("text2.txt");                                                          //вызываем функию для создания  файла text2.txt 
            writeFile(mass(first), "text2.txt", true);                                        //вызываем функцию для записи массива сопоставления обработанных номеров необработаным
                                                                                             //в только что созданный файл text2.txt
            

        }

    }
}


