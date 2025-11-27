using DinoGame.Utils;
using System.Collections.Immutable;

namespace DinoGame.Resource
{
    public class ResourceHandler
    {
        public static ImmutableArray<Resource> Resources = ImmutableArray<Resource>.Empty;

        public static void LoadDefaultResources()
        {
            Resources = Resources.AddRange(new Resource[]
            {
                new Picture(Identifier.Of(Globals.NAMESPACE, "obstacle_1"), "Resources/obstacle-1.gif").Load(),
                new Picture(Identifier.Of(Globals.NAMESPACE, "obstacle_2"), "Resources/obstacle-2.gif").Load(),
                new Picture(Identifier.Of(Globals.NAMESPACE, "running"), "Resources/running.gif").Load(),
                new Picture(Identifier.Of(Globals.NAMESPACE, "dead"), "Resources/dead.png").Load(),
            });
        }

        public static Resource GetResource(Identifier id)
        {
            return Resources.FirstOrDefault(r => r.Id == id)
                ?? throw new KeyNotFoundException($"Resource with ID {id.Namespace}:{id.Source} not found.");
        }
    }
}