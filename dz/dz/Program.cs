using System;
using System.Security.Permissions;

namespace dz
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public class Block
    {
        
    }

    public class Sword : Block, IHit
    {
        public void Durability()
        {

        }

        public void Damage()
        {
            
        }
    }

    public class DiamondSword: Sword
    {
        const int DamagePerHit = 20;
        SwordMaterials swordMaterial = SwordMaterials.Diamond;
    }

    public interface IHit
    {
        void Durability();
        void Damage();
    }
    
    public enum SwordMaterials
    {
        Wood,
        Stone,
        Iron,
        Gold,
        Diamond
    }

    public interface IMovable
    {
        bool TryToMove();
        void Move();
    }

    public class Boat: Block, IMovable, IBreaking
    {
        public bool TryToMove()
        {
            return true;
        }
        public void Move()
        {
            
        }

        public void Health()
        {
            
        }
        public const int BoatSpeed=10;
    }

    public interface IBreaking
    {
        void Health();
    }
}












