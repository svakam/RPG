namespace Character
{
    public class Character
    {
        public enum SkinType { get; set; }
        public decimal Height { get; set; }
        public enum EyeColor { get; set; }
        public enum HairColor { get; set; }
        public enum HairStyle { get; set; }
        public enum NoseBase { get; set; }
    }

    public enum SkinType
    {
        TypeI,
        TypeII,
        TypeIII,
        TypeIV,
        TypeV,
        TypeVI
    }

    public enum EyeColor
    {
        DARKBROWN,
        BROWN,
        LIGHTBROWN,
        GRAY,
        GREEN,
        HAZEL,
        AMBER,
        RED
    }

    public enum HairColor
    {
        BLACK,
        DARKBROWN,
        BROWN,
        LIGHTBROWN,
        DARKBLONDE,
        BLONDE,
        LIGHTBLONDE,
        WHITE,
        RED,
        GREEN,
        BLUE,
        VIOLET,
        YELLOW
    }

    public enum HairStyle
    {
        STRAIGHT,
        WAVY,
        CURLY
    }

    public enum NoseContour
    {
        STRAIGHT,
        CONVEX,
        CONCAVE,
        WAVYBRIDGED
    }

    public enum NoseSize
    {
        BUTTON,
        SMALL,
        MEDIUM,
        LARGE,
        PINOCCHIO
    }

    public enum NoseBase
    {
        STRAIGHT,
        RAISED,
        LOWERED
    }
}