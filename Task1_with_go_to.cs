using System;
using System.IO;

namespace Task1
{
    class Task1_with_go_to
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"Text_Example.txt");
            int text_length = text.Length;
            int words_show = 5;
            int i = 0;
            string current_word = "";

            int word_count = 0;

            int start_pos = 0;
            int j = 0;
            int duplicates = 0;
            string[] arr_words = new string[5000];



        while_loop:
            if ((text[i] >= 65) && (text[i] <= 90) || (text[i] >= 97) && (text[i] <= 122) || text[i] == 45)
            {
                if ((text[i] >= 65) && (text[i] <= 90))
                {
                    current_word += (char)(text[i] + 32);
                }
                else
                {
                    current_word += text[i];
                }
            }
            else
            {
                if (current_word != "" && current_word != null && current_word != "-" && current_word != "no"  && current_word != "in" && current_word != "\"" && current_word != "a" && current_word != "on" && current_word != "of" && current_word != "at" && current_word != "is" && current_word != "\n" && current_word != "\r" && current_word != "\r\n" && current_word != "\n\r") 
                { 
                    arr_words[word_count] = current_word;
                    word_count++;
                }
                current_word = "";
            }
            i++;
            if (i < text_length)
            {
                goto while_loop;
            }
            else
            {
                if (current_word != "" && current_word != null && current_word != "-" && current_word != "no" && current_word != "in" && current_word != "\"" && current_word != "a" && current_word != "on" && current_word != "of" && current_word != "at" && current_word != "is" && current_word != "\n" && current_word != "\r" && current_word != "\r\n" && current_word != "\n\r")
                {
                    arr_words[word_count] = current_word;
                    word_count++;
                }
            }
            string[] word_once_arr = new string[5000];
            int[] counter_arr = new int[5000];

            int amount_of_words = arr_words.Length;
 
            i = 0;



        while_loop_counter:
            start_pos = 0;
            int current_length = word_once_arr.Length;
            j = 0;




        for_loop:
            if (j < current_length && word_once_arr[j] != null)
            {
                if (word_once_arr[j] == arr_words[i])
                {
                    start_pos = j;
                    goto for_loop_end;

                }
                j++;
                goto for_loop;
            }




        for_loop_end:
            if (start_pos == 0)
            {
                word_once_arr[i - duplicates] = arr_words[i];
                counter_arr[i - duplicates] = 1;
            }
            else
            {
                counter_arr[start_pos] += 1;
                duplicates++;
            }
            i++;
            if (i < amount_of_words && arr_words[i] != null)
            {
                goto while_loop_counter;
            }
            int length = counter_arr.Length;
            j = 0;
            int inner_i = 0;



        sort_loop:
            if (j < length && counter_arr[j] != 0)
            {
                inner_i = 0;
            sort_inner_loop:
                if (inner_i < length - j - 1 && counter_arr[inner_i] != 0)
                {
                    if (counter_arr[inner_i] < counter_arr[inner_i + 1])
                    {
                        int temp = counter_arr[inner_i];
                        counter_arr[inner_i] = counter_arr[inner_i + 1];
                        counter_arr[inner_i + 1] = temp;



                        string temp2 = word_once_arr[inner_i];
                        word_once_arr[inner_i] = word_once_arr[inner_i + 1];
                        word_once_arr[inner_i + 1] = temp2;
                    }
                    inner_i++;
                    goto sort_inner_loop;
                }

                j++;
                goto sort_loop;
            }
            int f = 0;



        print_loop:
            if (f < length && word_once_arr[f] != null && f < words_show)
            {
                Console.WriteLine("{0} - {1}", word_once_arr[f], counter_arr[f]);
                f++;
                goto print_loop;
            }
        }
    }
}
