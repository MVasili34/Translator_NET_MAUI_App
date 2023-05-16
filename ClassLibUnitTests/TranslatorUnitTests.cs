using MainLibrary;

namespace ClassLibUnitTests
{
    public class TranslatorUnitTests
    {
        [Fact]
        public void TestGetEnglishTranslation()
        {
            //����������
            string key = "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";
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
            string key = "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";
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