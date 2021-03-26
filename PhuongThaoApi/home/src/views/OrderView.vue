<template>
    <div class="order">
        <div>
            <h1>Hóa đơn thanh toán</h1>
        </div>
        <order-grid />
    </div>
</template>

<script>
import OrderGrid from '../components/order/OrderGrid.vue'
export default {
  components: { OrderGrid },
    
}
</script>

<style scoped>
h1{
    text-align: center;
}
</style>