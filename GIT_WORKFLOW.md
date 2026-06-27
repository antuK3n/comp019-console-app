# Activity 3 — Git Workflow Demonstration

This repository uses the C# console application from Activity 2 to demonstrate
the core Git commands and branching.

## Commands demonstrated

### Commit
```bash
git add .
git commit -m "Initial commit: simple C# console calculator"
git commit -m "Add modulus (remainder) operation to the calculator"
```

### Push
```bash
git push origin main
```

### Pull
A change (`NOTES.md`) was made directly on GitHub, then pulled into the local
repository:
```bash
git pull origin main
```

### Revert
A commit was made and then undone with `git revert`, which creates a new commit
that reverses the previous one:
```bash
git commit -m "Add experimental debug comment"
git revert HEAD
git push origin main
```

## Branching
A separate branch holds an expanded version of the application with extra blocks
of code (a "scientific mode" with **power** and **square root** operations):
```bash
git checkout -b feature/scientific-mode
# ... edited Program.cs to add Power() and SquareRoot() ...
git commit -m "Add scientific mode: power and square root operations"
git push -u origin feature/scientific-mode
```

- `main` branch: calculator with Add, Subtract, Multiply, Divide, Modulus
- `feature/scientific-mode` branch: the above **plus** Power (x ^ y) and Square root

## Commit history (main)
```
Revert "Add experimental debug comment"
Add experimental debug comment
Add NOTES.md on remote (to demonstrate pull)
Add modulus (remainder) operation to the calculator
Initial commit: simple C# console calculator
```
