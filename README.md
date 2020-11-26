# UnityCheckpoints

A basic system to handle level checkpoints and 'respawning'.

## Outline

- Checkpoint
- Respawnable
- WorldBorder

## Things I still need to work out

- The convention of system generics that allow Unity's platform and ecosystem to diversify.
- Common interfaces for repeated tasks.
  - i.e. Obtaining if the collider is a trigger or not.
- Decide what components should be *required*.
  - BoxCollider
- Decide if 2D space is worth supporting within this project and how to support it in the *best* possible way.