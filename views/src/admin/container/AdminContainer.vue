<template>
    <div>
        <the-header></the-header>
        <router-view></router-view>

    </div>
</template>

<script>
import TheHeader from '../components/TheHeader'

export default {
    components:{
        TheHeader
    }
}
</script>

<style>

</style>