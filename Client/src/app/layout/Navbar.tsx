import { AppBar, Toolbar, Typography } from "@mui/material";
import { useEffect } from "react";

export default function Navbar() {
  // Load Cormorant Garamond if not already available
  useEffect(() => {
    const link = document.createElement("link");
    link.href =
      "https://fonts.googleapis.com/css2?family=Cormorant+Garamond:ital,wght@1,500&display=swap";
    link.rel = "stylesheet";
    document.head.appendChild(link);
  }, []);

  return (
    <AppBar
      position="fixed"
      sx={{
        backgroundColor: "#4B2E2E", // Deep burgundy
        color: "#F5EBDD", // Soft cream text
        boxShadow: "0 2px 8px rgba(0,0,0,0.2)",
        borderBottom: "1px solid #3a1f1f",
      }}
    >
      <Toolbar>
        <Typography
          variant="h5"
          sx={{
            fontFamily: "'Cormorant Garamond', serif",
            fontStyle: "italic",
            fontWeight: 500,
            letterSpacing: 1.5,
            fontSize: "2rem",
          }}
        >
          Crimson Wines
        </Typography>
      </Toolbar>
    </AppBar>
  );
}
