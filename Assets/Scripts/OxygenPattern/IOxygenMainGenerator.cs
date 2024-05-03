public interface IOxygenMainGenerator : IOxygenGenerator
{
    void AddEnhancer(Enhancer enhancer);

    void RemoveEnhancer(Enhancer enhancer);
}