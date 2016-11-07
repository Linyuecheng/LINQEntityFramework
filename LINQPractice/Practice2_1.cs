using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    class Practice2_1
    {
        public Practice2_1()
        {
            List<string> weekDayList = new List<string> { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            Console.WriteLine("原始陣列內容：");
            foreach (var item in weekDayList)
            {
                Console.WriteLine(item + ",");
            }

            Console.WriteLine("篩選第1個字元為T的陣列字串：");
            IEnumerable<string> enumWeek = weekDayList.Where(weekday => weekday.StartsWith("T"));
            foreach (var item in enumWeek)
            {
                Console.WriteLine(item + ",");
            }

        }
    }
}
