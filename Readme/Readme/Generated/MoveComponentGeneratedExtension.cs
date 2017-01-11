//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public partial class Entity {

        public MoveComponent move { get { return (MoveComponent)GetComponent(ComponentIds.Move); } }
        public bool hasMove { get { return HasComponent(ComponentIds.Move); } }

        public void AddMove(int newSpeed) {
            var component = CreateComponent<MoveComponent>(ComponentIds.Move);
            component.speed = newSpeed;
            AddComponent(ComponentIds.Move, component);
        }

        public void ReplaceMove(int newSpeed) {
            var component = CreateComponent<MoveComponent>(ComponentIds.Move);
            component.speed = newSpeed;
            ReplaceComponent(ComponentIds.Move, component);
        }

        public void RemoveMove() {
            RemoveComponent(ComponentIds.Move);
        }
    }

    public partial class Matcher {

        static IMatcher _matcherMove;

        public static IMatcher Move {
            get {
                if(_matcherMove == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Move);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherMove = matcher;
                }

                return _matcherMove;
            }
        }
    }
}
