using App;

namespace Tests
{
    // ��������� ��������� ����� ������� �������� ������ ������
    // ������� ������ (�����) �������� � ������ (����) ����� ...
    [TestClass]
    public class StringHelperTest
    {
        // ... ������� ������ - �������� ����� (��� ������� ������)
        [TestMethod]
        public void EllipsisTest()
        {
            StringHelper stringHelper = new();
            Assert.IsNotNull(stringHelper, "New StringHelper should be Non-Null");
            Assert.AreEqual(                          // ���� � ������������� ��������� -
                "Hello...",                           // ���������� ������. �������� -
                stringHelper                          // ��������� ��������, ���� - 
                    .Ellipsis("Hello, World!", 5),    // ��������.
                "'Hello, World!' -> 'Hello...'"       // ����������� - ����������� ���
            );                                        // ������ �����
            // ����� ��� ������ ����� �����, ��� ���� �����������
            // �������� ��������, ���� ���� �. �������� ���� �������
            // ����������� ��������� - ������� �����.
            // ���������, ��� ������ ����, return "Hello..." ���� ��������� ����
            Assert.AreEqual(
                "����� ��� ����...",
                stringHelper
                    .Ellipsis("����� ��� ������ ����� �����", 15) );
            // return max==5 ? "Hello..." : "����� ��� ����..."

        }
    }
}
