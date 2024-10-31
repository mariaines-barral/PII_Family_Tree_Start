namespace Library;

public class Visitor
{
    public void AgeSum(Node<Person> node, int result = 0)
    {
        result += node.Element.Age;
        foreach (Node<Person> child in node.Children)
        {
            
        }
    }
}