using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 题目一 字符串数组中最长的字符串
            ////题目1、用方法来实现：有一个字符串数组，求数组中最长的字符串
            //string[] names = { "马龙","迈克尔乔丹","雷吉米勒","蒂姆邓肯","科比布莱恩特"};
            //string max = GetLongest(names);
            //Console.WriteLine("给定字符串最长的为:{0}",max);
            //Console.ReadKey();
            #endregion

            #region 题目二 计算数组的平均值
            ////题目2、用方法来实现：请计算出一个整形数组的平均值，保留两位小数；
            //int[] numbers = { 1,2,7};
            //double avg = GetAvg(numbers);
            //Console.WriteLine("最初平均数为{0}", avg);
            //Console.WriteLine("使用0:0.00平均数为{0:0.00 }",avg);//会进行四舍五入
            ////保留两位小数；
            //string s=avg.ToString("0.00");//会进行四舍五入
            //Console.WriteLine("使用ToString平均数为{0}", s);
            ////将字符串重新转换为double赋值给avg；
            //avg = Convert.ToDouble(s);
            //Console.WriteLine("ToString转换为Double平均数为{0}", avg);
            //Console.ReadKey();
            #endregion

            #region 题目三 判断用户输入的是否为质数
            //题目3、写一个方法，用来判断用户输入的数字是不是质数
            //再写一个方法，要求用户只能输入数字，输入有误就一直让用户输入；

            //while (true)//放在while（true）中，使代码可以一直执行；
            //{
            //    Console.WriteLine("请输入一个数字:");
            //    string str = Console.ReadLine();
            //    int number = GetNumber(str);
            //    Console.WriteLine("您输入的数字转换后的结果为:{0}", number);
            //    //判断是否为质数
            //    bool b = IsPrime(number);
            //    Console.WriteLine("您输入的数字是否为质数：{0}", b);
            //    //Console.ReadKey();
            //}
            #endregion

            #region 题目四 接受用户输入判断等级
            //接受输入后判断等级并显示出来
            //判断依据如下：等级={优（90—100分）；良（80-89分）}



            #endregion
        }

        /// <summary>
        /// 判断给定的数字是否为质数
        /// </summary>
        /// <param name="number">给定的数字</param>
        /// <returns>返回的结果true或false</returns>
        public static bool IsPrime(int number)
        {
            if (number<2)
            {
                return false;
            }
            else
            {
                
                for (int i = 2; i < number; i++)//从2除，除到自身减1
                {
                    if (number % i == 0)
                    {
                        //给非质数准备的
                        return false;
                    }
                }
                //给质数准备的；
                return true;
            }
        }

        /// <summary>
        /// 把用户输入的数转换为数字，如果有误，一直让用户重新输入
        /// </summary>
        /// <param name="strNumber">用户的输入</param>
        /// <returns>返回的数字</returns>
        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return number;
                }
                catch (Exception)
                {

                    Console.WriteLine("输入有误，请重新输入一个数字");
                    strNumber = Console.ReadLine();
                }
            }

        }

        /// <summary>
        /// 求数组的平均数
        /// </summary>
        /// <param name="nums">给定的数组</param>
        /// <returns>返回平均数</returns>
        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }


        /// <summary>
        /// 求给定数组中最长的字符串
        /// </summary>
        /// <param name="s">输入的数组</param>
        /// <returns>返回到的最长字符串</returns>
        public static string GetLongest(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length>max.Length)
                {
                    max = s[i];
                }
            }
            return max;
        }

    }
}
