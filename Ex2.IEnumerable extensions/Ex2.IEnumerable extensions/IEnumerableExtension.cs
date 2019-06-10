using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.IEnumerable_extensions
{
    public static class IEnumerableExtension
    {
        //sum
        public static T Sum <T>(this IEnumerable <T> array ) where T: IComparable
        {
            dynamic sum = 0;

            foreach(var num in array)
            {
                sum += num;
            }

            return sum;

        }
        //product
        public static T Product<T>(this IEnumerable<T> array) where T:IComparable
        {
            dynamic product=1;

            foreach(var num in array)
            {
                product*=num;
            }

            return product;
        }

        //minim
        public static T Min<T>(this IEnumerable<T> array) where T:IComparable
        {
            dynamic minItem=array.First();

            foreach(var num in array) 
            {
                if(num.CompareTo(minItem)< 0)
                {
                    minItem=num;
                }

            } 
            return minItem;
        }


        //maxim
        public static T Max<T>(this IEnumerable<T> array) where T:IComparable 
        {
            dynamic maxItem=array.First();

            foreach(var num in array)
            {
                if(num.CompareTo(maxItem) > 0)
                {
                    maxItem=num;

                }
            }
                return maxItem;
                  

        }

        //average

        public static T Avrg<T>(this IEnumerable<T>array )where T:IComparable
        {
            if(array.Count() > 0)
            {
                dynamic average= array.Sum();
                average/= array.Count();
            
            return average;
            }

            else
            {
                return default(T);
            }
            
        }

    }
}
