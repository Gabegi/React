import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";
import type { Product } from "../../models/product";

import {
  Box,
  Button,
  Container,
  Divider,
  Grid,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableRow,
  TextField,
  Typography,
} from "@mui/material";

export default function ProductDetails() {
  const { id } = useParams();
  const [product, setProduct] = useState<Product | null>(null);

  useEffect(() => {
    fetch(`https://localhost:7020/api/Product/${id}`)
      .then((response) => response.json())
      .then((data) => setProduct(data))
      .catch((error) => console.log(error));
  }, [id]);

  if (!product) return <div>Could not fetch product details...</div>;

  const productDetails = [
    { label: "Name", value: product.name },
    { label: "Description", value: product.description },
    { label: "Type", value: product.type },
    { label: "Brand", value: product.brand },
    { label: "Quantity in stock", value: product.quantityInStock },
  ];
  return (
    <Container maxWidth="lg">
      <Grid container spacing={6} sx={{ mx: "auto" }}>
        <Grid item xs={12} md={6}>
          <Box
            sx={{
              width: "100%",
              height: 400,
              display: "flex",
              justifyContent: "center",
              alignItems: "center",
              backgroundColor: "#f5f5f5",
              overflow: "hidden",
            }}
          >
            <img
              src={product?.pictureUrl}
              alt={product?.name ?? "product image"}
              style={{
                maxWidth: "100%",
                maxHeight: "100%",
                objectFit: "contain",
                padding: "10px",
              }}
            />
          </Box>
        </Grid>

        <Grid item xs={12} md={6}>
          <Typography variant="h3">{product.name}</Typography>
          <Divider sx={{ mb: 2 }} />
          <Typography variant="h4" color="secondary">
            ${product.price.toFixed(2)}
          </Typography>
          <TableContainer>
            <Table sx={{ "& td": { fontSize: "1rem" } }}>
              <TableBody>
                {productDetails.map((detail, index) => (
                  <TableRow key={index}>
                    <TableCell>
                      <Typography fontWeight="bold">{detail.label}</Typography>
                    </TableCell>
                    <TableCell>{detail.value}</TableCell>
                  </TableRow>
                ))}
              </TableBody>
            </Table>
          </TableContainer>
          <Grid container spacing={2} marginTop={3}>
            <Grid item xs={6}>
              <TextField
                variant="outlined"
                type="number"
                label="Quantity in basket"
                fullWidth
                defaultValue={1}
              />
            </Grid>
            <Grid item xs={6}>
              <Button
                sx={{ height: "55px" }}
                color="primary"
                size="large"
                variant="contained"
                fullWidth
              >
                Add to basket
              </Button>
            </Grid>
          </Grid>
        </Grid>
      </Grid>
    </Container>
  );
}
