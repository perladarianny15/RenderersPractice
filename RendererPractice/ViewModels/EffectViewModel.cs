using System;
using Xamarin.Forms;

namespace RendererPractice.ViewModels
{
    public class EffectViewModel
    {
        public EffectViewModel()
        {
            var entry = new Entry
            {
                Text = "Effect attached to an Entry"
            };
            entry.Effects.Add(Effect.Resolve("RenderedPractice.EntryEffect"));

        }
    }
}
