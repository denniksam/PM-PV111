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

        [TestMethod]
        public void SpacefyTest()
        {
            StringHelper stringHelper = new();
            Assert.IsNotNull(stringHelper, "New StringHelper should be Non-Null");
            // 1. ���� ���������� �� ����, �� ����������� �����
            Assert.AreEqual("1 000", stringHelper.Spacefy(1000));
            // 3. ��� �������� ������� �������� ������ ��� ������
            // ������ ���� ���� �������������� (���. �. 2.2 � �����)
            // - ���������� ���� �����
            Dictionary<double, String> testCases = new()
            {
                { 2, "2" },
                { 20, "20" },
                { 200, "200" },
                { 2000, "2 000" },
                { 750387326, "750 387 326" },
                { 3750387326, "3 750 387 326" },  // �� ������� ����������� ��� <int> (�� uint)
                { -3750387326, "-3 750 387 326" },  // �� ������� ����������� �� long
                { 1000.1, "1 000.1" },  // 5. �� ������� ����������� �� double
                { 1000.123, "1 000.123" },
                { 1000.1234, "1 000.123 4" },
                { 1000.12345, "1 000.123 45" },
                { 1000.123456, "1 000.123 456" },
                { 0.1, "0.1" },  
                { 0.01, "0.01" },
                { 0.001, "0.001" },
                { 0.0001, "0.000 1" },
                { 0.00001, "0.000 01" },
                { 0, "0" },
                { 1.0, "1" },
            };
            foreach( var testCase in testCases )
            {
                Assert.AreEqual(
                    testCase.Value,
                    stringHelper.Spacefy(testCase.Key),
                    $"Spacefy({testCase.Key})"
                );
            }
        }
    }
}
/* �� ������� ������ ��������� ������� � ������ ������:
 * 3750387326 -> 3 750 387 326
 * Spacefy(int) -> String
 */
