// Большое количество полей и громоздкий конструктор созданы намеренно,
// чтобы имитировать крупный объект-значение для чистоты эксперимента

namespace Copying_the_structure_and_class
{
    // Структура с 50 полями
    public struct SimpleStruct50
    {
        public int Field1; public int Field2; public int Field3; public int Field4; public int Field5;
        public int Field6; public int Field7; public int Field8; public int Field9; public int Field10;
        public int Field11; public int Field12; public int Field13; public int Field14; public int Field15;
        public int Field16; public int Field17; public int Field18; public int Field19; public int Field20;
        public int Field21; public int Field22; public int Field23; public int Field24; public int Field25;
        public int Field26; public int Field27; public int Field28; public int Field29; public int Field30;
        public int Field31; public int Field32; public int Field33; public int Field34; public int Field35;
        public int Field36; public int Field37; public int Field38; public int Field39; public int Field40;
        public int Field41; public int Field42; public int Field43; public int Field44; public int Field45;
        public int Field46; public int Field47; public int Field48; public int Field49; public int Field50;

        public SimpleStruct50(
            int field1, int field2, int field3, int field4, int field5, int field6, int field7, int field8, int field9, int field10,
            int field11, int field12, int field13, int field14, int field15, int field16, int field17, int field18, int field19, int field20,
            int field21, int field22, int field23, int field24, int field25, int field26, int field27, int field28, int field29, int field30,
            int field31, int field32, int field33, int field34, int field35, int field36, int field37, int field38, int field39, int field40,
            int field41, int field42, int field43, int field44, int field45, int field46, int field47, int field48, int field49, int field50
        )
        {
            Field1 = field1; Field2 = field2; Field3 = field3; Field4 = field4; Field5 = field5;
            Field6 = field6; Field7 = field7; Field8 = field8; Field9 = field9; Field10 = field10;
            Field11 = field11; Field12 = field12; Field13 = field13; Field14 = field14; Field15 = field15;
            Field16 = field16; Field17 = field17; Field18 = field18; Field19 = field19; Field20 = field20;
            Field21 = field21; Field22 = field22; Field23 = field23; Field24 = field24; Field25 = field25;
            Field26 = field26; Field27 = field27; Field28 = field28; Field29 = field29; Field30 = field30;
            Field31 = field31; Field32 = field32; Field33 = field33; Field34 = field34; Field35 = field35;
            Field36 = field36; Field37 = field37; Field38 = field38; Field39 = field39; Field40 = field40;
            Field41 = field41; Field42 = field42; Field43 = field43; Field44 = field44; Field45 = field45;
            Field46 = field46; Field47 = field47; Field48 = field48; Field49 = field49; Field50 = field50;
        }

        // Тестируемый метод №1: Поверхностное копирование (побитовое копирование)
        public SimpleStruct50 ShallowCopy()
        {
            return this;
        }

        // Тестируемый метод №2: Глубокое копирование
        public SimpleStruct50 DeepCopy()
        {
            return new SimpleStruct50(
                 Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10,
                 Field11, Field12, Field13, Field14, Field15, Field16, Field17, Field18, Field19, Field20,
                 Field21, Field22, Field23, Field24, Field25, Field26, Field27, Field28, Field29, Field30,
                 Field31, Field32, Field33, Field34, Field35, Field36, Field37, Field38, Field39, Field40,
                 Field41, Field42, Field43, Field44, Field45, Field46, Field47, Field48, Field49, Field50
            );
        }
    }
}