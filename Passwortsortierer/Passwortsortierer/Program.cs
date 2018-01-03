using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        static string GetSha1Hash(SHA1 sha1Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        static String[] r_numbers(int range)
        {
            Random rd = new Random();
            List<String> st = new List<String>();

            for (int i = 0; i <= range; i++)
            {
                String stt = "";

                for (int j = 0; j <= rd.Next(3, 30); j++)
                {
                    stt += rd.Next(0, 9).ToString();
                }
                st.Add(stt);
            }

            return st.ToArray();
        }

        static String[] r_numbers_letters(int range)
        {
            Random rd = new Random();
            List<String> st = new List<String>();
            String chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";


            for (int i = 0; i <= range; i++)
            {
                String stt = "";
                for (int j = 0; j <= rd.Next(3, 30); j++)
                {

                    if (rd.Next(0, 2) != 0)
                    {
                        stt += rd.Next(0, 9).ToString();
                    }
                    else
                    {
                        stt += chars[rd.Next(0, chars.Length)];
                    }
                }



                st.Add(stt);
            }


            return st.ToArray();
        }

        static String[] r_numbers_letters_spc(int range)
        {
            Random rd = new Random();
            List<String> st = new List<String>();
            String chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String spec_chars = "%#@!*?;:^&+=-_§$£/\'";


            for (int i = 0; i <= range; i++)
            {
                String stt = "";
                for (int j = 0; j <= rd.Next(3, 30); j++)
                {
                    int rdi = rd.Next(0, 3);
                    if (rdi == 0)
                    {
                        stt += rd.Next(0, 9).ToString();
                    }
                    else if (rdi == 1)
                    {
                        stt += chars[rd.Next(0, chars.Length)];
                    }
                    else
                    {
                        stt += spec_chars[rd.Next(0, spec_chars.Length)];
                    }
                }

                st.Add(stt);
            }


            return st.ToArray();
        }


        static String[] r_numbers_lettersBS_spc_min6(int range)
        {
            Random rd = new Random();
            List<String> st = new List<String>();
            String chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String spec_chars = "%#@!*?;:^&+=-_§$£/\'";

            for (int i = 0; i <= range; i++)
            {
                String stt = "";


                do
                {
                    for (int j = 0; j <= rd.Next(6, 30); j++)
                    {
                        int rdi = rd.Next(0, 3);
                        if (rdi == 0)
                        {
                            stt += rd.Next(0, 9).ToString();
                        }
                        else if (rdi == 1)
                        {
                            stt += chars[rd.Next(0, chars.Length)];
                        }
                        else
                        {
                            stt += spec_chars[rd.Next(0, spec_chars.Length)];
                        }
                    }
                } while (!((Regex.IsMatch(stt, @"\d")) && stt.Any(c => char.IsNumber(c)) && stt.Any(c => char.IsUpper(c)) && stt.Any(c => char.IsLower(c))));


                st.Add(stt);
            }


            return st.ToArray();
        }




        static String[] r_min8c(int range)
        {
            Random rd = new Random();
            List<String> st = new List<String>();
            String chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String spec_chars = "%#@!*?;:^&+=-_§$£/\'";

            for (int i = 0; i <= range; i++)
            {
                String stt = "";

                for (int j = 0; j <= rd.Next(8, 30); j++)
                {
                    int rdi = rd.Next(0, 3);
                    if (rdi == 0)
                    {
                        stt += rd.Next(0, 9).ToString();
                    }
                    else if (rdi == 1)
                    {
                        stt += chars[rd.Next(0, chars.Length)];
                    }
                    else
                    {
                        stt += spec_chars[rd.Next(0, spec_chars.Length)];
                    }
                }

                st.Add(stt);
            }


            return st.ToArray();
        }

        // lettersBS_min8cc
        static String[] r_lettersBS_min8cc(int range)
        {
            Random rd = new Random();
            List<String> st = new List<String>();
            String chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i <= range; i++)
            {
                String stt = "";


                do
                {
                    for (int j = 0; j <= rd.Next(8, 30); j++)
                    {
                        int rdi = 2;//rd.Next(0, 2);
                        if (rdi == 0)
                        {
                            stt += rd.Next(0, 9).ToString();
                        }
                        else
                        {
                            stt += chars[rd.Next(0, chars.Length)];
                        }

                    }
                } while (!(stt.Any(c => char.IsUpper(c)) && stt.Any(c => char.IsLower(c))));


                st.Add(stt);
            }


            return st.ToArray();
        }




        static String[] filte_numbers(String[] input)
        {
            List<String> st = new List<String>();
            foreach (String i in input)
            {
                if (Regex.IsMatch(i, @"^\d+$")) { st.Add(i); }
            }

            return st.ToArray();
        }

        static String[] filte_numbers_letters(String[] input)
        {
            string pattern = @"^[a-zA-Z0-9]";
            string pattern2 = @"^[a-zA-Z]";
            List<String> st = new List<String>();
            foreach (String i in input)
            {
                if (!(Regex.IsMatch(i, pattern2)) && (Regex.IsMatch(i, pattern)) && !(Regex.IsMatch(i, @"^\d+$"))) { st.Add(i); }
            }

            return st.ToArray();
        }


        static String[] filte_numbers_letters_spc(String[] input)
        {
            string pattern = @"^[a-zA-Z0-9]";
            List<String> st = new List<String>();
            foreach (String i in input)
            {
                if (!(Regex.IsMatch(i, pattern)) && (Regex.IsMatch(i, @"\d")) && !(Regex.IsMatch(i, @"^\d+$"))) { st.Add(i); }
            }

            return st.ToArray();
        }

        static String[] filter_numbers_lettersBS_spc_min6(String[] input)
        {
            string pattern = @"^[A-Za-z0-9]";

            List<String> st = new List<String>();
            foreach (String i in input)
            {
                if ((i.Length >= 6) && (Regex.IsMatch(i, @"\d")) && !(Regex.IsMatch(i, pattern)) && i.Any(c => char.IsUpper(c)) && i.Any(c => char.IsLower(c))) { st.Add(i); }
            }


            return st.ToArray();




        }


        static String[] filter_min8c(String[] input)
        {
            List<String> st = new List<String>();
            foreach (String i in input)
            {
                if (i.Length >= 8) { st.Add(i); }
            }

            return st.ToArray();
        }

        static String[] filter_lettersBS_min8cc(String[] input)
        {
            string pattern = @"^[A-Za-z]";
            List<String> st = new List<String>();
            foreach (String i in input)
            {
                if ((i.Length >= 8) && !(i.Any(c => char.IsNumber(c))) && (Regex.IsMatch(i, pattern)) && i.Any(c => char.IsUpper(c)) && i.Any(c => char.IsLower(c))) { st.Add(i); }
            }


            return st.ToArray();
        }







        static String[] hash_array(MD5 md5Hash, String[] input)
        {
            List<String> st = new List<String>();
            foreach (String i in input)
            {
                st.Add(GetMd5Hash(md5Hash, i));
            }
            return st.ToArray();
        }

        static String[] hash_array(SHA1 sHA1, String[] input)
        {
            List<String> st = new List<String>();
            foreach (String i in input)
            {
                st.Add(GetSha1Hash(sHA1, i));
            }
            return st.ToArray();
        }


        static void Main(string[] args)
        {
            String input;
            String[] input_split;

            DateTime preWorkt = DateTime.UtcNow;


            input = System.IO.File.ReadAllText("Passwords.txt");

            input_split = input.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
            );

            MD5 md5Hash = MD5.Create();
            SHA1 sha = new SHA1CryptoServiceProvider();

            Console.Out.WriteLine("splitting: " + (DateTime.UtcNow.Subtract(preWorkt)).TotalSeconds);

            DateTime preWork = DateTime.UtcNow;

            String[] numbers = filte_numbers(input_split);
            String[] numbers_letters = filte_numbers_letters(input_split);
            String[] numbers_letters_spc = filte_numbers_letters_spc(input_split);
            String[] numbers_lettersBS_spc_min6c = filter_numbers_lettersBS_spc_min6(input_split);
            String[] min8c = filter_min8c(input_split);
            String[] lettersBS_min8c = filter_lettersBS_min8cc(input_split);

            Console.Out.WriteLine("filtering: " + (DateTime.UtcNow.Subtract(preWork)).TotalSeconds);
            preWork = DateTime.UtcNow;

            String[] r_numbers_v = r_numbers(numbers.Length);
            String[] r_r_numbers_letters_v = r_numbers_letters(numbers_letters.Length);
            String[] r_numbers_letters_spc_v = r_numbers_letters_spc(numbers_letters_spc.Length);
            String[] r_numbers_lettersBS_spc_min6c_v = r_numbers_lettersBS_spc_min6(numbers_lettersBS_spc_min6c.Length);
            String[] r_min8c_v = r_min8c(min8c.Length);
            String[] r_lettersBS_min8c_v = r_lettersBS_min8cc(lettersBS_min8c.Length);

            Console.Out.WriteLine("generating random lists: " + (DateTime.UtcNow.Subtract(preWork)).TotalSeconds);
            preWork = DateTime.UtcNow;

            System.IO.File.WriteAllLines("numbers.txt", numbers);
            System.IO.File.WriteAllLines("numbers_letters.txt", numbers_letters);
            System.IO.File.WriteAllLines("numbers_letters_spc.txt", numbers_letters_spc);
            System.IO.File.WriteAllLines("numbers_lettersBS_spc_min6c.txt", numbers_lettersBS_spc_min6c);
            System.IO.File.WriteAllLines("min8c.txt", min8c);
            System.IO.File.WriteAllLines("lettersBS_min8c.txt", lettersBS_min8c);

            Console.Out.WriteLine("writing filtered lists to file: " + (DateTime.UtcNow.Subtract(preWork)).TotalSeconds);
            preWork = DateTime.UtcNow;

            System.IO.File.WriteAllLines("numbers-sha1.txt", hash_array(sha, numbers));
            System.IO.File.WriteAllLines("numbers_letters-sha1.txt", hash_array(sha, numbers_letters));
            System.IO.File.WriteAllLines("numbers_letters_spc-sha1.txt", hash_array(sha, numbers_letters_spc));
            System.IO.File.WriteAllLines("numbers_lettersBS_spc_min6c-sha1.txt", hash_array(sha, numbers_lettersBS_spc_min6c));
            System.IO.File.WriteAllLines("min8c-sha1.txt", hash_array(sha, min8c));
            System.IO.File.WriteAllLines("lettersBS_min8c-sha1.txt", hash_array(sha, lettersBS_min8c));

            Console.Out.WriteLine("hashing sha1 filtered lists and writing to file: " + (DateTime.UtcNow.Subtract(preWork)).TotalSeconds);
            preWork = DateTime.UtcNow;

            System.IO.File.WriteAllLines("numbers-md5.txt", hash_array(md5Hash, numbers));
            System.IO.File.WriteAllLines("numbers_letters-md5.txt", hash_array(md5Hash, numbers_letters));
            System.IO.File.WriteAllLines("numbers_letters_spc-md5.txt", hash_array(md5Hash, numbers_letters_spc));
            System.IO.File.WriteAllLines("numbers_lettersBS_spc_min6c-md5.txt", hash_array(md5Hash, numbers_lettersBS_spc_min6c));
            System.IO.File.WriteAllLines("min8c-md5.txt", hash_array(md5Hash, min8c));
            System.IO.File.WriteAllLines("lettersBS_min8c-md5.txt", hash_array(md5Hash, lettersBS_min8c));


            Console.Out.WriteLine("hashing md5 filtered lists and writing to file: " + (DateTime.UtcNow.Subtract(preWork)).TotalSeconds);
            preWork = DateTime.UtcNow;

            System.IO.File.WriteAllLines("numbers-random.txt", r_numbers_v);
            System.IO.File.WriteAllLines("numbers_letters-random.txt", r_r_numbers_letters_v);
            System.IO.File.WriteAllLines("numbers_letters_spc-random.txt", r_numbers_letters_spc_v);
            System.IO.File.WriteAllLines("numbers_lettersBS_spc_min6c-random.txt", r_numbers_lettersBS_spc_min6c_v);
            System.IO.File.WriteAllLines("min8c-random.txt", r_min8c_v);
            System.IO.File.WriteAllLines("lettersBS_min8c-random.txt", r_lettersBS_min8c_v);

            Console.Out.WriteLine("writing random lists to file:  " + (DateTime.UtcNow.Subtract(preWork)).TotalSeconds);
            preWork = DateTime.UtcNow;

            System.IO.File.WriteAllLines("numbers-random-md5.txt", hash_array(md5Hash, r_numbers_v));
            System.IO.File.WriteAllLines("numbers_letters-random-md5.txt", hash_array(md5Hash, r_r_numbers_letters_v));
            System.IO.File.WriteAllLines("numbers_letters_spc-random-md5.txt", hash_array(md5Hash, r_numbers_letters_spc_v));
            System.IO.File.WriteAllLines("numbers_lettersBS_spc_min6c-random-md5.txt", hash_array(md5Hash, r_numbers_lettersBS_spc_min6c_v));
            System.IO.File.WriteAllLines("min8c-random-md5.txt", hash_array(md5Hash, r_min8c_v));
            System.IO.File.WriteAllLines("lettersBS_min8c-random-md5.txt", hash_array(md5Hash, r_lettersBS_min8c_v));

            Console.Out.WriteLine("hashing md5 random lists and writing to file: " + (DateTime.UtcNow.Subtract(preWork)).TotalSeconds);
            preWork = DateTime.UtcNow;

            System.IO.File.WriteAllLines("numbers-random-sha1.txt", hash_array(sha, r_numbers_v));
            System.IO.File.WriteAllLines("numbers_letters-random-sha1.txt", hash_array(sha, r_r_numbers_letters_v));
            System.IO.File.WriteAllLines("numbers_letters_spc-random-sha1.txt", hash_array(sha, r_numbers_letters_spc_v));
            System.IO.File.WriteAllLines("numbers_lettersBS_spc_min6c-random-sha1.txt", hash_array(sha, r_numbers_lettersBS_spc_min6c_v));
            System.IO.File.WriteAllLines("min8c-random-sha1.txt", hash_array(sha, r_min8c_v));
            System.IO.File.WriteAllLines("lettersBS_min8c-random-sha1.txt", hash_array(sha, r_lettersBS_min8c_v));

            Console.Out.WriteLine("hashing sha1 random lists and writing to file: " + (DateTime.UtcNow.Subtract(preWork)).TotalSeconds);
            preWork = DateTime.UtcNow;

            Console.Out.WriteLine("total: " + (DateTime.UtcNow.Subtract(preWorkt)).TotalSeconds);

            Console.ReadKey();
        }
    }
}
