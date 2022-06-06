using System;
using System.Collections.Generic;
using System.Linq;

namespace Meal_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meals = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> food = new Queue<string>();
            int[] calories = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> daylyCalo = new Stack<int>();

            int salat = 350;
            int soup = 490;
            int pasta = 680;
            int steak = 790;

            foreach (var item in meals)
            {
                food.Enqueue(item);
            }
            foreach (var item in calories)
            {
                daylyCalo.Push(item);
            }

            while ((food.Count > 0) && (daylyCalo.Count > 0))
            {
                if (food.Peek() == "salad")
                {
                    if (daylyCalo.Peek() >= salat )
                    {
                        int curr = daylyCalo.Peek() - salat;
                        daylyCalo.Pop();
                        food.Dequeue();
                        daylyCalo.Push(curr);
                    }

                    else
                    {
                        int curr = Math.Abs(daylyCalo.Pop() - salat);
                        if (daylyCalo.Count == 0)
                        {
                            food.Dequeue();
                            break;
                        }

                        food.Dequeue();
                        int minusQueue = daylyCalo.Pop() - curr;

                        daylyCalo.Push(minusQueue);
                    }
                }
                else if (food.Peek() == "soup")
                {
                    if (daylyCalo.Peek() >= soup)
                    {
                        int curr = daylyCalo.Peek() - soup;
                        daylyCalo.Pop();
                        food.Dequeue();
                        daylyCalo.Push(curr);
                    }

                    else
                    {
                        int curr = Math.Abs(daylyCalo.Pop() - soup);
                        
                        if (daylyCalo.Count == 0)
                        {
                            food.Dequeue();
                            break;
                        }

                        food.Dequeue();
                        int minusQueue = daylyCalo.Pop() - curr;

                        daylyCalo.Push(minusQueue);
                    }
                }
               else if (food.Peek() == "pasta")
                {
                    if (daylyCalo.Peek() >= pasta)
                    {
                        int curr = daylyCalo.Peek() - pasta;
                        daylyCalo.Pop();
                        food.Dequeue();
                        daylyCalo.Push(curr);
                    }

                    else
                    {
                        int curr = Math.Abs(daylyCalo.Pop() - pasta);
                        if (daylyCalo.Count == 0)
                        {
                            food.Dequeue();
                            break;
                        }

                        food.Dequeue();
                        int minusQueue = daylyCalo.Pop() - curr;

                        daylyCalo.Push(minusQueue);
                    }
                }
                else if (food.Peek() == "steak")
                {
                    if (daylyCalo.Peek() >= steak)
                    {
                        int curr = daylyCalo.Peek() - steak;
                        daylyCalo.Pop();
                        food.Dequeue();
                        daylyCalo.Push(curr);
                    }

                    else
                    {
                        int curr = Math.Abs(daylyCalo.Pop() - steak);
                        if (daylyCalo.Count == 0)
                        {
                            food.Dequeue();
                            break;
                        }

                        food.Dequeue();
                        int minusQueue = daylyCalo.Pop() - curr;
                        
                        daylyCalo.Push(minusQueue);
                    }
                }


            }

            if (food.Count == 0)
            {
                Console.WriteLine($"John had {meals.Length} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", daylyCalo)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {meals.Length - food.Count} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", food)}.");
            }





        }
    }
}
