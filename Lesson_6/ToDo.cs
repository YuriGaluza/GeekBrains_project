namespace Level_1.Lesson_6
{
    public class ToDo
    {
        private string Title;
        private bool IsDone;
        private int Number;

        public ToDo()
        {
        }

        public ToDo(string title, bool isDone, int Number)
        {
            this.Title = title;
            this.IsDone = isDone;
            this.Number = Number;
        }

        public string Title1
        {
            get => Title;
            set => Title = value;
        }

        public bool IsDone1
        {
            get => IsDone;
            set => IsDone = value;
        }

        public int Number1
        {
            get => Number;
            set => Number = value;
        }
    }
}