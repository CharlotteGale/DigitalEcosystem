public interface IOrganism
{
    void Tick();
    void InteractWith(IOrganism other);
    string GetState();
}