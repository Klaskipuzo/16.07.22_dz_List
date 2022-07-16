using System.Text;
using System.Linq;


namespace dz_dairy
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            var data = new List<Task>();

            Console.WriteLine("Здравствуйте, это программа работы с задачами!");
            while (true)
            {
                Console.WriteLine("Пожелуйста выберите дейсвие из спика:");
                Console.WriteLine("1 - создавать задачу(имя, категория)");
                Console.WriteLine("2 - отметить задачу как выполненную");
                Console.WriteLine("3 - просматривать список аквтивных и выполненных задач");
                var input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        var newTask = CreateTask();
                        data.Add(newTask);
                        break;
                    case 2:
                        MarkComplete(data);
                        break;
                    case 3:
                        Show(data);
                        break;
                    default:
                        continue;
                }
            }
        }

        static Task CreateTask()
        {
            var task = new Task { Times = DateTime.Now };

            Console.Write("Введите название задачи: ");
            task.Name = Console.ReadLine();

            Console.Write("Введите категорию задачи: ");
            task.Category = Console.ReadLine();

            return task;
        }

        static void MarkComplete(List<Task> data)
        {

            Console.WriteLine("Выберите задачу которую выполнили");

            foreach (var task in data)
            {

                var index1 = data.IndexOf(task);
                Console.WriteLine($"\n{index1 + 1}) Задача: {task.Name}\tКатегория: {task.Category}\tДата: {task.Times}");



                var input = int.Parse(Console.ReadLine());
                if (input == 1)
                {

                    task.IsComplete = true;
                    return;
                }
                else if (input == 2)
                {

                    task.IsComplete = true;
                    return;
                }
                else if (input == 3)
                {

                    task.IsComplete = true;
                    return;
                }
                else if (input == 4)
                {

                    task.IsComplete = true;
                    return;
                }
                else if (input == 5)
                {

                    task.IsComplete = true;
                    return;
                }


            }







        }

        static void Show(List<Task> data)
        {
            foreach (var task in data)
            {
                var index = data.IndexOf(task);

                if (task.IsComplete == true)
                {
                    Console.WriteLine($"\n{index + 1}) Задача: {task.Name}\tКатегория: {task.Category}\tДата: {task.Times}\tСтатус: Выполнено");
                }
                else
                {
                    Console.WriteLine($"\n{index + 1}) Задача: {task.Name}\tКатегория: {task.Category}\tДата: {task.Times}\tСтатус: В работе");
                }
            }


        }
        static void Complite()
        {

        }
    }
    class Task
    {
        public string Name;
        public string Category;
        public DateTime Times;
        public bool IsComplete;
    }
}
