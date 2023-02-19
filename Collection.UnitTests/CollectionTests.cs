namespace Collection.UnitTests
{
    public class CollectionTests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Shte stanat neshtata!");
        }

        [Test]
        public void Test_Collection_EmptyConstructor()
        {
            var coll = new Collection<int>();
            Assert.AreEqual(coll.ToString(), "[]");
        }

        [Test]
        public void Test_Collection_ConstructorSingleItem()
        {
            var coll = new Collection<int>(5);
            Assert.AreEqual(coll.ToString(), "[5]");
        }

        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {
            var coll = new Collection<int>(5, 6, 7);
            Assert.AreEqual(coll.ToString(), "[5, 6, 7]");
        }
        [Test]
        public void Test_Collection_Add()
        {
            var coll = new Collection<int>(5);
            coll.Add(7);

            Assert.AreEqual(coll.ToString(), "[5, 7]");
        }

        [Test]
        public void Test_Collection_CountAndCapacity()
        {
            var coll = new Collection<int>(5, 7);
            coll.Add(7);

            Assert.AreEqual(coll.Count, 3);
            Assert.AreEqual(coll.Capacity, 16);
        }

        [Test]
        public void Test_Collection_AddRange()
        {
            var coll = new Collection<int>(5);
            coll.AddRange(6, 7, 8);

            Assert.AreEqual(coll.ToString(), "[5, 6, 7, 8]");
        }
        [Test]
        public void Test_Collection_GetByIndex()
        {
            var coll = new Collection<int>(5, 6, 7);
            var item = coll[1];

            Assert.AreEqual(item.ToString(), "6");
        }

        [Test]
        public void Test_Collection_SetByIndex()
        {
            var coll = new Collection<int>(5, 6, 7);
            coll[1] = 1;

            Assert.AreEqual(coll.ToString(), "[5, 1, 7]");

        }

        [Test]
        public void Test_Collection_InsertAt()
        {
            var coll = new Collection<int>(5, 6, 8);
            coll.InsertAt(2, 7);

            Assert.AreEqual(coll.ToString(), "[5, 6, 7, 8]");
        }

        [Test]
        public void Test_Collection_Exchange()
        {
            var coll = new Collection<int>(5, 6, 7, 8);
            coll.Exchange(1, 2);

            Assert.AreEqual(coll.ToString(), "[5, 7, 6, 8]");
        }

        [Test]
        public void Test_Collection_AddRangeWithGrow()
        {
            var coll = new Collection<int>();
            int oldCapacity = coll.Capacity;
            var newColl = Enumerable.Range(1000, 2000).ToArray();
            coll.AddRange(newColl);
            string expectedColl = "[" + string.Join(", ", newColl) + "]";
            Assert.That(coll.ToString(), Is.EqualTo(expectedColl));
            Assert.That(coll.Capacity, Is.GreaterThanOrEqualTo(oldCapacity));
            Assert.That(coll.Capacity, Is.GreaterThanOrEqualTo(coll.Count));
        }

    }
}