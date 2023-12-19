namespace Exercise;

public class Category
{
    public string catergoryName { get; set; }

    public Category(string catergoryName)
    {
        this.catergoryName = catergoryName;
    }

    public override string ToString()
    {
        return $"{catergoryName}";
    }

}