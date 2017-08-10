public interface ICharacter
{
    int BaseMaxHealth
    { set; get; }
    int BaseAttack
    { set; get; }
    int BaseDefense
    { set; get; }

    int CurrentHealth
    { get; set; }
    int CurrentMaxHealth
    { get; set; }
    int CurrentAttack
    { get; set; }
    int CurrentDefense
    { get; set; }

    void AlterHealth(int healthChange);
}
