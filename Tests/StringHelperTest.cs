using App;

namespace Tests
{
    // структура модульних тестів відповідає структурі самого проєкту
    // кожному модулю (класу) програми є модуль (клас) тестів ...
    [TestClass]
    public class StringHelperTest
    {
        // ... кожному методу - тестовий метод (або декілька методів)
        [TestMethod]
        public void EllipsisTest()
        {
            StringHelper stringHelper = new();
            Assert.IsNotNull(stringHelper, "New StringHelper should be Non-Null");
            Assert.AreEqual(                          // Одне з найпоширеніших тверджень -
                "Hello...",                           // твердження рівності. Спочатку -
                stringHelper                          // очікуване значення, потім - 
                    .Ellipsis("Hello, World!", 5),    // фактичне.
                "'Hello, World!' -> 'Hello...'"       // Опціонально - повідомлення при
            );                                        // провалі тесту
            // Тести слід робити таким чином, щоб вони гарантовано
            // показали проблему, якщо вона є. Наявність малої кількості
            // константних тверджень - поганий підхід.
            // наприклад, при одному тесті, return "Hello..." буде проходити тест
            Assert.AreEqual(
                "Тести слід роби...",
                stringHelper
                    .Ellipsis("Тести слід робити таким чином", 15) );
            // return max==5 ? "Hello..." : "Тести слід роби..."

        }
    }
}
