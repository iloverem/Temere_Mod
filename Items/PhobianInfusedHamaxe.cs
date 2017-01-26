using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Temere.Items
{
    public class PhobianInfusedHamaxe : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Phobian Infused Ham-axe";
            item.melee = true;
            item.damage = 12;
            item.toolTip = "Formerly belonging to Freddy Krueger apparently.";
            // item.width = ;
            // item.height = ;
            item.useStyle = 1;
            item.useAnimation = 26;
            item.useTime = 26;
            item.useSound = 1;
            item.knockBack = 3;
            item.value = 420;
            item.autoReuse = true;
            item.hammer = 45;
            item.axe = 45;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "NightmareBar", 13);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
