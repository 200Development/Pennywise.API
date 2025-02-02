# Pennywise.API
## Git Commit Policy
## Git Commit Naming Convention

Use a **prefix** that clearly defines the type of commit, followed by a concise description of the change.

### **Commit Prefixes (Types)**

| Prefix     | Description                                     |
|------------|---------------------------------|
| `feat:`    | Adding a new feature  |
| `fix:`     | Fixing a bug  |
| `style:`   | UI/UX or CSS changes (no logic changes)  |
| `refactor:`| Code restructuring without changing behavior  |
| `perf:`    | Performance improvements  |
| `chore:`   | Maintenance tasks (deps, configs, build)  |
| `test:`    | Adding or updating tests  |
| `docs:`    | Updating documentation  |
| `ci:`      | Changes to CI/CD workflows  |
| `revert:`  | Reverting a previous commit  |

### **Commit Message Format**
```
<type>: <short summary>
```
_(Keep summaries under 50 characters.)_

#### **Examples**
```
feat: Add bulk payment processing
fix: Correct late fee calculation
style: Update button colors for better contrast
refactor: Simplify invoice validation logic
perf: Optimize database query for listing search
chore: Update dependencies and cleanup package.json
docs: Add API documentation for phone payment flow
test: Add unit tests for transaction service
ci: Update GitHub Actions workflow for deployment
revert: Revert "feat: Add bulk payment processing"
```

### **Commit Guidelines**
- **Use a clear prefix**: Every commit must start with a category prefix (e.g., `feat:`, `fix:`, `style:`).
- **Keep summaries short**: Max **50 characters**.
- **Use present-tense, imperative form**: e.g., "Add feature" instead of "Added feature".
- **Provide a detailed description if necessary**.
- **Commit frequently, but meaningfully**: Avoid large commits.

This structure ensures a clean, readable, and organized Git history.
