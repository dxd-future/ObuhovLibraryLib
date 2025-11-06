namespace LibraryLib
{
    public class LibraryFunctions
    {
        // Переменные string, содержащие название библеотеки и главного библиотекаря
        private string LibraryName = "Городская библиотека г. Чита";
        private string ChiefLibrarian = "Иванова Мария Петровна";

        // Список ФИО сотрудников библеотеки
        private List<string> staff = new List<string>()
        {
            "Петров П.С.",
            "Сидорова А.В.",
            "Козлов И.Д.",
            "Иванова М.П."
        };

        // Метод возвращающий ФИО главного библиотекаря
        public string GetChiefLibrarian()
        {
            return ChiefLibrarian;
        }

        // Метод возвращающий название библиотеки
        public string GetLibraryName()
        {
            return LibraryName;
        }

        // Метод изменяющий ФИО главного библиотекаря, если сотрудник есть в списке
        public bool SetChiefLibrarian(string Fullname)
        {
            // Если список сотрудников содержит ФИО сотрудника, то сотрудник присваивается главному библеотекарю и возвращает True, иначе False
            if (staff.Contains(Fullname))
            {
                ChiefLibrarian = Fullname;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Метод генерирующий код книги в формате CAT_number
        public string GenerateBookCode(string category, int number)
        {
            // переменная которая принимает название категории и оставляет лишь 3 заглавных символа
            string cat = category.ToUpper().Substring(0, Math.Min(3, category.Length));
            // возвращает код книги собранный из параметров category и number
            return $"{cat}_{number}";
        }

        // Метод возвращает список сотрудников
        public List<string> GetStaff()
        {
            // возвращает список сотрудников
            return staff;
        }

        // Метод добавляет нового сотрудника
        public void AddStaff(string Fullname)
        {
            // метод Add добавляет в список сотрудников параметр Fullname
            staff.Add(Fullname);
        }
    }
}
