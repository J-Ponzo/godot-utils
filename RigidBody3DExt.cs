using Godot;
using System;

public static class RigidBody3DExt
{
	public enum ForceMode
	{
        /// <summary>
        /// Add a continuous force to the rigidbody, using its mass.
        /// </summary>
        Force,
        /// <summary>
        /// Add a continuous acceleration to the rigidbody, ignoring its mass.
        /// </summary>
        Acceleration,
        /// <summary>
        /// Add an instant force impulse to the rigidbody, using its mass.
        /// </summary>
		Impulse,
        /// <summary>
        /// Add an instant velocity change to the rigidbody, ignoring its mass.
        /// </summary>
		VelocityChange
    }

    public static void AddForce(this RigidBody3D rigidBody3D, Vector3 force, ForceMode mode = ForceMode.Force)
    {
        switch (mode)
        {
            case ForceMode.Force:
                rigidBody3D.ApplyCentralForce(force);
                break;
            case ForceMode.Acceleration:
                rigidBody3D.ApplyCentralForce(force/rigidBody3D.Mass);
                break;
            case ForceMode.Impulse:
                rigidBody3D.ApplyCentralImpulse(force);
                break;
            case ForceMode.VelocityChange:
                rigidBody3D.ApplyCentralImpulse(force/rigidBody3D.Mass);
                break;
        }
    }

    public static void AddForceAtPosition(this RigidBody3D rigidBody3D, Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
    {
        switch (mode)
        {
            case ForceMode.Force:
                rigidBody3D.ApplyForce(force, position);
                break;
            case ForceMode.Acceleration:
                rigidBody3D.ApplyForce(force / rigidBody3D.Mass, position);
                break;
            case ForceMode.Impulse:
                rigidBody3D.ApplyImpulse(force, position);
                break;
            case ForceMode.VelocityChange:
                rigidBody3D.ApplyImpulse(force / rigidBody3D.Mass, position);
                break;
        }
    }
}
