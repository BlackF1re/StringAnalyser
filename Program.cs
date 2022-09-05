namespace string_analyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите сообщение");
            string input_string = Console.ReadLine();
            StringAnalyser(input_string);
        }

        private static void StringAnalyser(string input_string)
        {
            string analyzer_dict = "!\"#$%&'()*+,-./0123456789:;<=>?@[\\]^_`{|}~" +
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "абвгдежзийклмнопрстуфхцчшщъыьэюяАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            Dictionary<char, int> dic = new();
            foreach (char ch in analyzer_dict)
                dic.Add(ch, 0);
            foreach (char ch in input_string)
            {
                if (analyzer_dict.Contains(ch.ToString()))
                    dic[ch]++;
            }
            foreach (var pair in dic)
                if (pair.Value > 0)
                    Console.WriteLine("{0} {1}", pair.Key, pair.Value);

        }
    }
}