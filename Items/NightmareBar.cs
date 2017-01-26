using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Temere.Items
{
    public class NightmareBar : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Nightmare Bar";
            item.width = 30;
            item.height = 26;
            item.maxStack = 99;
            item.toolTip = "Welcome to my nightmare. In solid form!";
            item.value = 150;
            item.rare = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "NightmareDrop_NightmareFuel", 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}
