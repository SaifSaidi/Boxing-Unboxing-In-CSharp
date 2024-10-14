using System.Collections;

namespace NonGenericCollectionsProblem
{
    public class NonGenericCollections
    {

        public static void Problem()
        {
            //Using ArrayList, which is a non-generic collection,
            //causes boxing when adding int values and unboxing when retrieving them.
            ArrayList data = [];

            for (int i = 0; i < 100; i++)
            {
                data.Add(i);  // boxing int to object
            }


            int sum = 0;
            foreach (var item in data)
            {
                sum += (int)item; // unboxing object to int
            }

            Console.WriteLine(sum);
        }

        public static void Solution()
        {
            //causes boxing when adding int values and unboxing when retrieving them.
            // ArrayList data = [];
            
            //Using Generic <int> collection
            List<int> data = [];

            for (int i = 0; i < 100; i++)
            {
                data.Add(i);
            }


            int sum = 0;
            foreach (var item in data)
            {
                // sum += (int)item; // unboxing object to int
                sum += item;  
            }

            Console.WriteLine(sum);
        }

    }
}
