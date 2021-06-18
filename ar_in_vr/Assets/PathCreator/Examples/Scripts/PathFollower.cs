using UnityEngine;

namespace PathCreation.Examples
{
    // Moves along a path at constant speed.
    // Depending on the end of path instruction, will either loop, reverse, or stop at the end of the path.
    public class PathFollower : MonoBehaviour
    {
        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public float speed = 5;
        public float ASmallAmount;
        float distanceTravelled;

        void Start()
        {
            if (pathCreator != null)
            {
                // Subscribed to the pathUpdated event so that we're notified if the path changes during the game
                pathCreator.pathUpdated += OnPathChanged;

            }
        }

        void Update()
        {
            if (pathCreator != null)
            {
                distanceTravelled += speed * Time.deltaTime;
                Vector3 currentPosition = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                Vector3 nextPosition = pathCreator.path.GetPointAtDistance(distanceTravelled + ASmallAmount, endOfPathInstruction);
                Vector3 heading = nextPosition - currentPosition;
                transform.LookAt(transform.position + heading);

              

                // the second argument, upwards, defaults to Vector3.up
                //Quaternion rotation = Quaternion.LookRotation(heading);
                //transform.rotation = rotation;

                transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled, endOfPathInstruction);
                //transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled, endOfPathInstruction);
            }
        }

        // If the path changes during the game, update the distance travelled so that the follower's position on the new path
        // is as close as possible to its position on the old path
        void OnPathChanged()
        {
            distanceTravelled = pathCreator.path.GetClosestDistanceAlongPath(transform.position);
        }

        public void Reset()
        {
            distanceTravelled = 0;
        }
    }
}