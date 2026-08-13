Deep Charcoal/Slate  ── Background Base (Rich Leather/Ink vibe)
Warm Parchment ── Card & Workspace Containers 
Antique Gold/Amber ── Primary Highlights, Active States, Key Metrics 
Crimson & Jade ── Alert States (Unpaid, Paid, In-Progress)

### MVP Palette Definition

- **Base Surface (Dark Mode Default):** `#1E1E24` (Deep Ink / Slate)—Keeps the app sleek, professional, and easy on the eyes during late-night maker sessions.
- **Card & Container Surfaces:** `#2B2D35` (Elevated Ink) with subtle `#D4AF37` (Muted Antique Gold) borders.
- **Text & Typography:** Soft off-white (`#EAEAEA`) for main readability, with muted gold for headers and primary calls to action.
- **Status Badges (Queue States):**
    - _Deposit Paid:_ Soft Amber (`#D97706`)
    - _In Progress:_ Warm Brass (`#B45309`)
    - _Fully Paid / Ready:_ Forest Jade (`#059669`)
    - _On Hold / Unpaid:_ Crimson (`#DC2626`)



## Privacy UX Mechanics (Mask & Toggle)

Since privacy is central to the ledger, handling Personally Identifiable Information (PII) on screen needs to be seamless:
- **Default State (Hover-to-Reveal):**
    - Customer names and handles are rendered with a subtle CSS blur or masked pill (`••••••••` or `[ 🔒 Customer #1024 ]`).
    - Hovering over the field temporarily unmasks the string.
- **Global Privacy Toggle (Header Control):**
    - A small eye/lock icon in the top header bar toggles global privacy:
        - 👁️ **Streamer/Public Mode (Default):** Blurs/masks all PII across the queue and ledger. Hovering works for quick checks.
        - 🔓 **Private Desk Mode:** Keeps all decrypted handles visible across the view so you don't have to keep hovering while doing heavy administrative entry.