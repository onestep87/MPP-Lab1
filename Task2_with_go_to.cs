using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    class Task2_with_go_to
    {
        static void Main1(string[] args)
        {
            string text = File.ReadAllText(@"WriteText.txt");
            int text_length = text.Length;
            int i = 0;
            string curr_word = "";
            string[] words_arr = new string[100000];
            string[,] page_word_arr = new string[10000, 10000];
            int word_count = 0;
            int row_count = 0;
            int page_count = 0;
            int page_word_counter = 0;
        while_loop:
            if ((text[i] >= 65) && (text[i] <= 90) || (text[i] >= 97) && (text[i] <= 122) || text[i] == 45 || text[i] == 234 || text[i] == 225 || text[i] == 224)
            {
                if ((text[i] >= 65) && (text[i] <= 90))
                {
                    curr_word += (char)(text[i] + 32);
                }
                else
                {
                    curr_word += text[i];
                }
            }
            else
            {
                if (text[i] == '\n')
                {
                    row_count++;
                }
                if (row_count > 45)
                {
                    page_count++;
                    page_word_counter = 0;
                    row_count = 0;
                }
                if (curr_word != "" && curr_word != null && curr_word != "-" && curr_word != "no" && curr_word != "from" && curr_word != "the" && curr_word != "by" && curr_word != "and" && curr_word != "i" && curr_word != "in" && curr_word != "or" && curr_word != "any" && curr_word != "for" && curr_word != "to" && curr_word != "\"" && curr_word != "a" && curr_word != "on" && curr_word != "of" && curr_word != "at" && curr_word != "is" && curr_word != "\n" && curr_word != "\r" && curr_word != "\r\n" && curr_word != "\n\r")
                {

                    words_arr[word_count] = curr_word;
                    word_count++;
                    page_word_arr[page_count, page_word_counter] = curr_word;
                    page_word_counter++;
                }
                curr_word = "";
            }
            i++;
            if (i < text_length)
            {
                goto while_loop;
            }
            else
            {
                if (curr_word != "" && curr_word != null && curr_word != "-" && curr_word != "no" && curr_word != "from" && curr_word != "the" && curr_word != "by" && curr_word != "and" && curr_word != "i" && curr_word != "in" && curr_word != "or" && curr_word != "any" && curr_word != "for" && curr_word != "to" && curr_word != "\"" && curr_word != "a" && curr_word != "on" && curr_word != "of" && curr_word != "at" && curr_word != "is" && curr_word != "\n" && curr_word != "\r" && curr_word != "\r\n" && curr_word != "\n\r")
                {
                    words_arr[word_count] = curr_word;
                    word_count++;
                }
            }
            string[] words_once_arr = new string[100000];
            int[] words_once_count_arr = new int[100000];
            int words_amount = words_arr.Length;
            i = 0;
            int insertPos = 0;
            int j = 0;
            int dubs = 0;
        while_loop_count:
            insertPos = 0;
            int current_length = words_once_arr.Length;
            j = 0;
        for_loop:
            if (j < current_length && words_once_arr[j] != null)
            {
                if (words_once_arr[j] == words_arr[i])
                {
                    insertPos = j;
                    goto end_for_loop;

                }
                j++;
                goto for_loop;
            }
        end_for_loop:
            if (insertPos == 0)
            {
                words_once_arr[i - dubs] = words_arr[i];
                words_once_count_arr[i - dubs] = 1;
            }
            else
            {
                words_once_count_arr[insertPos] += 1;
                dubs++;
            }
            i++;
            if (i < words_amount && words_arr[i] != null)
            {
                goto while_loop_count;
            }
            int length = words_once_count_arr.Length;
            int k = 0;
            string[] words_once_arr_less_than_100 = new string[100000];
            int LastInsert = 0;
        words_less_than_100_loop:
            if (k < length && words_once_arr[k] != null)
            {
                if (words_once_count_arr[k] <= 100)
                {
                    words_once_arr_less_than_100[LastInsert] = words_once_arr[k];
                    LastInsert++;
                }
                k++;
                goto words_less_than_100_loop;
            }
            int write = 0;
            int sort = 0;
            bool toSwapWords = false;
            int counter = 0;
            int word_lenth_cur = 0;
            int word_lenth_next = 0;
        sort_loop:
            if (write < words_once_arr_less_than_100.Length && words_once_arr_less_than_100[write] != null)
            {
                sort = 0;
            inner_sort_loop:
                if (sort < words_once_arr_less_than_100.Length - write - 1 && words_once_arr_less_than_100[sort + 1] != null)
                {
                    word_lenth_cur = words_once_arr_less_than_100[sort].Length;
                    word_lenth_next = words_once_arr_less_than_100[sort + 1].Length;

                    int compare_lenth = word_lenth_cur > word_lenth_next ? word_lenth_next : word_lenth_cur;

                    toSwapWords = false;
                    counter = 0;
                alphabet_check:

                    if (words_once_arr_less_than_100[sort][counter] > words_once_arr_less_than_100[sort + 1][counter])
                    {
                        toSwapWords = true;
                        goto alphabet_check_end;
                    }
                    if (words_once_arr_less_than_100[sort][counter] < words_once_arr_less_than_100[sort + 1][counter])
                    {
                        goto alphabet_check_end;
                    }
                    counter++;
                    if (counter < compare_lenth)
                    {
                        goto alphabet_check;
                    }
                alphabet_check_end:
                    if (toSwapWords)
                    {
                        string temp = words_once_arr_less_than_100[sort];
                        words_once_arr_less_than_100[sort] = words_once_arr_less_than_100[sort + 1];
                        words_once_arr_less_than_100[sort + 1] = temp;
                    }
                    sort++;
                    goto inner_sort_loop;
                }
                write++;
                goto sort_loop;
            }
            k = 0;
            int less_than_100_length = words_once_arr_less_than_100.Length;
        print_loop:
            if (k < less_than_100_length && words_once_arr_less_than_100[k] != null)
            {
                Console.Write("{0} - ", words_once_arr_less_than_100[k]);
                int first_dim = 0;
                int second_dim = 0;
                int[] word_pages = new int[100];
                int pageInsert = 0;

            check_page:
                if (first_dim < 10000 && page_word_arr[first_dim, 0] != null)
                {
                    second_dim = 0;
                check_page_word:
                    if (second_dim < 10000 && page_word_arr[first_dim, second_dim] != null)
                    {
                        if (page_word_arr[first_dim, second_dim] == words_once_arr_less_than_100[k])
                        {
                            word_pages[pageInsert] = first_dim + 1;
                            pageInsert++;
                            first_dim++;
                            goto check_page;
                        }
                        second_dim++;
                        goto check_page_word;
                    }

                    first_dim++;
                    goto check_page;
                }
                int tired_counte = 0;
            pagination_loop:
                if (tired_counte < 100 && word_pages[tired_counte] != 0)
                {
                    if (tired_counte != 99 && word_pages[tired_counte + 1] != 0)
                    {
                        Console.Write("{0}, ", word_pages[tired_counte]);
                    }
                    else
                    {
                        Console.Write("{0}", word_pages[tired_counte]);
                    }
                    tired_counte++;
                    goto pagination_loop;
                }
                Console.WriteLine();
                k++;
                goto print_loop;
            }
        }
    }
}
