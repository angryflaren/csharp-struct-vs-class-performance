namespace Copying_the_structure_and_class
{
    // Класс с 3 полями
    public class SimpleClass3
    {
        public int Field1;
        public int Field2;
        public int Field3;

        public SimpleClass3(int field1, int field2, int field3)
        {
            Field1 = field1;
            Field2 = field2;
            Field3 = field3;
        }

        // Тестируемый метод №2: Глубокое копирование (создание нового объекта через конструктор)
        public SimpleClass3 DeepCopy()
        {
            return new SimpleClass3(
                Field1,
                Field2,
                Field3
            );
        }
    }
}