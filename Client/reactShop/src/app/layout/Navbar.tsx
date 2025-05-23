import { AppBar, Toolbar, Typography } from "@mui/material";

export default function Navbar() {
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
            letterSpacing: 1,
          }}
        >
          Rhone Valley Wines
        </Typography>
      </Toolbar>
    </AppBar>
  );
}
