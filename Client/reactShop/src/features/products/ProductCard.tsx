import {
  Card,
  CardMedia,
  CardContent,
  Typography,
  CardActions,
  Button,
} from "@mui/material";
import type { Product } from "../../app/models/product";

interface Props {
  product: Product;
}

export default function ProductCard({ product }: Props) {
  return (
    <Card>
      <CardMedia
        component="img"
        height="240"
        image={product.pictureUrl}
        alt={product.name}
        sx={{
          objectFit: "cover", // Ensures images fill the frame
        }}
      />
      <CardContent>
        <Typography variant="h6">{product.name}</Typography>
        <Typography color="text.secondary">{product.description}</Typography>
        <Typography sx={{ mt: 1 }}>${product.price.toFixed(2)}</Typography>
      </CardContent>
      <CardActions>
        <Button size="small">Add to Cart</Button>
        <Button size="small">Details</Button>
      </CardActions>
    </Card>
  );
}
