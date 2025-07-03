// Большое количество полей и громоздкий конструктор созданы намеренно,
// чтобы имитировать крупный объект-значение для чистоты эксперимента

namespace Copying_the_structure_and_class
{
    // Структура с 10 полями
    public struct SimpleStruct10
    {
        public int Field1;
        public int Field2;
        public int Field3;
        public int Field4;
        public int Field5;
        public int Field6;
        public int Field7;
        public int Field8;
        public int Field9;
        public int Field10;

        public SimpleStruct10(int field1, int field2, int field3, int field4, int field5, int field6, int field7, int field8, int field9, int field10)
        {
            Field1 = field1;
            Field2 = field2;
            Field3 = field3;
            Field4 = field4;
            Field5 = field5;
            Field6 = field6;
            Field7 = field7;
            Field8 = field8;
            Field9 = field9;
            Field10 = field10;
        }

        // Тестируемый метод №1: Поверхностное копирование (побитовое копирование)
        public SimpleStruct10 ShallowCopy()
        {
            return this;
        }

        // Тестируемый метод №2: Глубокое копирование
        public SimpleStruct10 DeepCopy()
        {
            return new SimpleStruct10(
                Field1,
                Field2,
                Field3,
                Field4,
                Field5,
                Field6,
                Field7,
                Field8,
                Field9,
                Field10
            );
        }
    }
}