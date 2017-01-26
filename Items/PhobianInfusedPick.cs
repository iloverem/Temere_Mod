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
    public class PhobianInfusedPick : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Phobian Infused Pick";
            item.toolTip = "Perfect for splitting skulls!";
            item.damage = 11;
            item.melee = true;
            //item.width = ;
            // item.height =;
            item.useTime = 28;
            item.useAnimation = 28;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 230;
            item.rare = 2;
            item.autoReuse = true;
            item.pick = 50;
            item.useSound = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "NightmareBar", 13);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
