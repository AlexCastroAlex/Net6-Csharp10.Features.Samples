namespace Net6_Csharp10.Features.Samples
{
    public class newfeatures
    {
        /// <summary>
        /// DateOnlyFeature
        /// </summary>
        /// <returns></returns>
        public DateOnly returnDateOnly()
        {
            DateOnly date = DateOnly.MinValue;
            Console.WriteLine(date); //Outputs 01/01/0001 (With no Time)
            return date;
        }


        /// <summary>
        /// timeOnly feature
        /// </summary>
        /// <returns></returns>
        public TimeOnly returnTimeOnly()
        {
            TimeOnly time = TimeOnly.MinValue;
            Console.WriteLine(time); //Outputs 12:00 AM
            return time;
        }


        /// <summary>
        /// LINQ OrDefault Value
        /// </summary>
        /// <returns></returns>
        public int? returnDefault()
        {
            var listint = new List<int?> { 1, 2, 2 };
            var search = 3;

            var foundValue = listint.FirstOrDefault(x => x == search, -1);
            if (foundValue == -1)
            {
                Console.WriteLine("We couldn't find the value");
            }
            return foundValue;
        }

        /// <summary>
        /// IEnumerable chunks
        /// </summary>
        public void IenumerabelChunks()
        {
            var list = Enumerable.Range(1, 100);
            var chunkSize = 10;
            foreach (var chunk in list.Chunk(chunkSize)) //Returns a chunk with the correct size. 
            {
                Parallel.ForEach(chunk, (item) =>
                {
                    //Do something Parallel here. 
                    Console.WriteLine(item);
                });
            }
        }

        /// <summary>
        /// Priority Queue
        /// </summary>
        public void PriorityQueue()
        {
            PriorityQueue<string, int> queue = new PriorityQueue<string, int>();
            queue.Enqueue("Item A", 0);
            queue.Enqueue("Item B", 60);
            queue.Enqueue("Item C", 2);
            queue.Enqueue("Item D", 1);

            while (queue.TryDequeue(out string item, out int priority))
            {
                Console.WriteLine($"Popped Item : {item}. Priority Was : {priority}");
            }
        }

        /// <summary>
        /// MaxBy MinBy
        /// </summary>
        public void MaxByMinBy()
        {
            List<Person> people = new List<Person>
                {
                    new Person
                    {
                        Name = "John Smith",
                        Age = 20
                    },
                    new Person
                    {
                        Name = "Jane Smith",
                        Age = 30
                    }
                };

            Console.WriteLine(people.MaxBy(x => x.Age)); //Outputs Person (John Smith)
            Console.WriteLine(people.MinBy(x => x.Age)); //Outputs Person (Jane Smith)
        }


        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }


    }
}
