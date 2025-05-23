import { AppBar, Toolbar, Typography } from "@mui/material";

export default function Navbar() {
  return (
    <AppBar
      position="fixed"
      // color="transparent" // Optional: Use this if you want a non-colored navbar
      // elevation={1}        // Optional: Reduce shadow for a flatter look
    >
      <Toolbar>
        <Typography
          variant="h5"
          sx={{
            fontFamily: '"Playfair Display", serif', // Elegant wine-shop feel
            fontWeight: "bold",
            letterSpacing: 1,
            ml: 1, // margin-left
          }}
        >
          My Wine Shop
        </Typography>
      </Toolbar>
    </AppBar>
  );
}
