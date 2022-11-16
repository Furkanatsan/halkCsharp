namespace AbstractANDInterface
{
    public abstract class Document
    {
        public string Owner { get; set; }
        public DateTime CreatedDate { get; set; }
        public void Copy(string from, string to)
        {

        }

        public void Move(string from, string to)
        {

        }

        public void ChangeName(string newName)
        {

        }

        public abstract void Open();
        public abstract void Save();


        public virtual void DocumentCreationInfo()
        {
            Console.WriteLine($"bu doküman, {CreatedDate.ToLongDateString()} tarihinde {Owner} tarafından oluşturuldu");
        }


    }

    public interface IPrintable
    {
        void Print();
    }

    public class PDFDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("PDF dokümanı açıldı");
        }


        public override void Save()
        {
            Console.WriteLine("PDF Kaydedildi");
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Excel dokümanı açıldı");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            Console.WriteLine("Excel dokümanı kaydedildi");
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Open()
        {
            Console.WriteLine("Word dokümanı açıldı");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            Console.WriteLine("Word dokümanı kaydedildi");
        }
    }


    public class DocumentComponent
    {
        public void SaveDocument(Document document)
        {
            document.Save();
        }
    }

    public class PrinterComponent
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }


}
