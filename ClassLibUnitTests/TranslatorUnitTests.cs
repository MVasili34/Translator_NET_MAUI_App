using MainLibrary;

namespace ClassLibUnitTests
{
    public class TranslatorUnitTests
    {
        [Fact]
        public void TestGetEnglishTranslation()
        {
            //����������
            string key = "key here";
            string temp = "0.7";
            var request = new AIMakesRequest(key, temp);

            //��������
            string actual = request.RequestTranslateToEn("������.");

            //����������
            Assert.Equal("Apple.", actual);
        }
        [Fact]
        public void TestGetRussianTranslation()
        {
            //����������
            string key = "key here";
            string temp = "0.7";
            var request = new AIMakesRequest(key, temp);

            //��������
            string actual = request.RequestTranslateToRu("Rabbit.");

            //����������
            Assert.Equal("������.", actual);
        }

        [Fact]
        public void CatchOpenAIKeyException()
        {
            //����������
            string key = "Some kind of a key";
            string temp = "0.7";
            var request = new AIMakesRequest(key, temp);


            //����������
            Assert.Equal("�������� ���� ����������� OpenAI!\n������� ����������.", request.RequestTranslateToEn("SomeText"));
        }
    }
}