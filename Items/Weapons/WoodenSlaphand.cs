using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;


namespace Temere.Items.Weapons
{
    public class WoodenSlaphand : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Wooden Slaphand";
            item.damage = 5;
            item.melee = true;
            item.width = 34;
            item.height = 30;
            item.toolTip = "May cause splinters";
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = 225;
            item.rare = 0;
            item.useSound = 1;
            item.autoReuse = false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 9);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
