import {
  Card,
  CardContent,
  CardMedia,
  Typography,
  CardActions,
  Button,
  Box,
} from "@mui/material";
import type { Product } from "../../app/models/product";

interface Props {
  product: Product;
}
export default function ProductCard({ product }: Props) {
  return (
    <Card sx={{ height: "100%", display: "flex", flexDirection: "column" }}>
      <Box
        sx={{
          height: 200,
          display: "flex",
          alignItems: "center",
          justifyContent: "center",
          overflow: "hidden",
          backgroundColor: "#f5f5f5",
        }}
      >
        <CardMedia
          component="img"
          image={product.pictureUrl}
          alt={product.name}
          sx={{
            maxHeight: "100%",
            maxWidth: "100%",
            objectFit: "contain",
          }}
        />
      </Box>

      <CardContent sx={{ flexGrow: 1 }}>
        <Typography variant="h6" gutterBottom>
          {product.name}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {product.description}
        </Typography>
        <Typography sx={{ mt: 1 }} fontWeight="bold">
          ${product.price.toFixed(2)}
        </Typography>
      </CardContent>

      <CardActions>
        <Button size="small">Add to Cart</Button>
        <Button size="small">Details</Button>
      </CardActions>
    </Card>
  );
}
